using Factory;
using GraafMachine.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    public abstract class BaseNode: ICloneable, IGetKey<String>
    {
        protected List<BaseNode> outputNodes;
        protected List<bool> inputs;
        protected string name;
        protected List<GraafController> observers;
        protected bool output;

        protected BaseNode()
        {
            observers = new List<GraafController>();
            outputNodes = new List<BaseNode>();
        }

        public static BaseNode create(String name)
        {
            return Factory.FactoryMethod<String, BaseNode>.create(name);
        }

        public void addOutputNode(BaseNode node)
        {
            outputNodes.Add(node);
        }

        public void addInput(bool input)
        {
            inputs.Add(input);
            work();
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public List<bool> getInputs()
        {
            return inputs;
        }

        public abstract string getKey();
        public abstract object Clone();
        public abstract void work();

        public void notifyObservers(bool output)
        {
            foreach (GraafController g in observers)
            {
                g.printOutput(this, output);
            }
        }
        public void Subscribe(GraafController observer)
        {
            observers.Add(observer);
           
        }
    }
}


#region From java


//	protected List<BaseNode> nextNodes;
//	protected Boolean output;
//	
//	protected BaseNode(){
//		nextNodes = new ArrayList<BaseNode>();
//	}
//	
//	protected void work(){
//		for(BaseNode node: nextNodes){
//			node.addInput(output);
//		}
//		for(BaseNode node: nextNodes){
//			node.work();
//		}
//	}
//	
//	protected void addInput(Boolean value){
//		
//	}
//	
//	protected void addNextNode(BaseNode node){
//		nextNodes.add(node);
//	}

#endregion