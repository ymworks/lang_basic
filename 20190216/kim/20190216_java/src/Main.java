
public class Main {
	public static void main(String[] args) {
		// 可変長引数
		paramsTest("a");
		paramsTest("a", "b");
		paramsTest("a", "b", "c");
	}
	
	public static void paramsTest(String ... strings) { // C#では 'params'
		int size = strings.length;
		for (int i = 0; i < size; i++) {
			System.out.println(strings[i]);
		}
	}
}
