package Controllers;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class GraafParser {

	private ArrayList<String> input;

	public GraafParser(String path) throws FileNotFoundException, IOException {
		input = new ArrayList<String>();
		// TODO process lines
		try (BufferedReader br = new BufferedReader(new FileReader(new File(path)))) {
			String line;
			while ((line = br.readLine()) != null) {
				input.add(line);
			}
		}
	}

	public ArrayList<String> getInput() {
		return input;
	}
}
