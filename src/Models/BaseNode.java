package Models;

import java.util.List;

public abstract class BaseNode {
	
	protected List<BaseNode> nextNodes;
	protected Boolean output;
	
	protected void work(){
		for(BaseNode node: nextNodes){
			node.addInput(output);
		}
		for(BaseNode node: nextNodes){
			node.work();
		}
	}
	
	protected void addInput(Boolean value){
		
	}
}
