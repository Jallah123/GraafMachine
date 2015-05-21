package Factorys;

import java.util.ServiceLoader;

import Models.BaseNode;

public class NodeFactory {
	
	private ServiceLoader<BaseNode> serviceLoader;
	
	public NodeFactory(){
		serviceLoader = ServiceLoader.load(BaseNode.class);
		for(BaseNode n: serviceLoader){
			System.out.println(n.getClass().getSimpleName());
		}
	}
	
	public static BaseNode getNode(String s){
		return null;
	}
}

/*

private static final Map<String, AbstractCommand> commands;
private static final ServiceLoader<AbstractCommand> loader;

static {
	commands = new HashMap<String, AbstractCommand>();
	loader = ServiceLoader.load(AbstractCommand.class);
	
	for (AbstractCommand command : loader) {
		commands.put(command.getClass().getSimpleName(), command);
	}
}

public static final AbstractCommand create(final String name) {
	if (commands.containsKey(name)) {
		return commands.get(name).copy();
	}
	
	final String message = String.format("Command '%s' was not found, is the services file up to date?", name);
	throw new IllegalArgumentException(message);
}
*/