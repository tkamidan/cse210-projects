using System.IO;
public class IO {
    public string[] Read(string filename) {
        string[] lines = System.IO.File.ReadAllLines(filename);
        return lines;
    }
    public void Write(string filename, List<string> lines) {
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (string line in lines) {
                outputFile.WriteLine(line);
            }
        }
    }
}