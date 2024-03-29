﻿using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    public abstract class BaseNode: ICloneable, IGetKey<String>
    {
        protected BaseNode()
        {
        }
        public static BaseNode create(String name)
        {
            return Factory.FactoryMethod<String, BaseNode>.create(name);
        }

        public abstract string getKey();
        public abstract object Clone();
        public abstract void work();
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