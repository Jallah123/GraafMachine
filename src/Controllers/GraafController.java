package Controllers;

import java.util.ArrayList;
import java.util.List;

import Factorys.NodeFactory;
import Models.BaseNode;

public class GraafController {
	
	private List<BaseNode> nodes;
	
	public GraafController() {
		nodes = new ArrayList<BaseNode>();
		NodeFactory nodee = new NodeFactory();
		GraafParser parser = new GraafParser("C:\\tmp\\graaf.txt");
		generateNodes(parser.getInput());
	}

	public void generateNodes(List<String> input) {	
		for (String s : input) {
			if (!s.contains("#") && !s.equals("")) {
				System.out.println(s);
				nodes.add(NodeFactory.getNode(s));
			}
		}
		linkNodes();
	}
	
	public void linkNodes(){
		for(BaseNode node: nodes){
			
		}
	}
}
