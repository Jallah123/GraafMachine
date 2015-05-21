package Controllers;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import Factorys.NodeFactory;

public class GraafParser {

	private List<String> input;

	public GraafParser(String path) {
		input = new ArrayList<String>();

		try {
			BufferedReader br = new BufferedReader(new FileReader(new File(path)));
			String line;
			while ((line = br.readLine()) != null) {
				input.add(line);
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public List<String> getInput() {
		return input;
	}
}
