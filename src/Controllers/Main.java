package Controllers;

import java.io.FileNotFoundException;
import java.io.IOException;

public class Main {

	public static void main(String[] args) {
		GraafParser parser = null;
		try {
			parser = new GraafParser("C:\\tmp\\graaf.txt");
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
		for(String s : parser.getInput()){
			System.out.println(s);
		}
	}
}
