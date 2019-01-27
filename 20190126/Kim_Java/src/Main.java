
public class Main {
	
	{
		int a = 1;
		//int a = 2;
	}
	// C#と違って、Javaではスコープさえ違ったら、同じ変数名が使える。
	int a = 3;
	
	public static void main(String[] args) {
		//parsingTest();
		//scopeTest();
		文字型の比較();
	}
	
	private static void scopeTest() {
		
	}

	private static void parsingTest() {
		int out = 1; // outは、Javaではキーワードではない。
		
		// int @for = 3;
		//int for = 1;
		
		// Console.WriteLine("Hello World!");
		System.out.println("Hello World!");
		
		// p.56
		int a = Integer.valueOf("123456");
		System.out.println("a=" + a);
		
		int x = 1;
		x = Integer.valueOf("文字列"); // Parsing
	}
	
	private static void statementTest() {
		// 式
		int age = 20;
		boolean result = age > 20;
		
		// ステートメント :ロジカルな何か。
		if (result) {
			System.out.println("お酒が飲める。");
		} else {
			System.out.println("お酒を飲んじゃダメ。");
		}
	}
	
	private static void 文字型の比較() {
		String a = "test";
		//
		char b = 'c'; // 3番目
		
		System.out.println("比較してみよう");
		System.out.println(b < 1);
	}
	
	private static void plusplus() {
		int i = 0;
		
		for (i = 0; i < 5; i++) { // 0 1 2 3 4
			System.out.println("index is=" + i);
		}
	}
	
	private static void instanceOfTest() {
		String aa = "abcde";
		System.out.println(aa instanceof String);
	}
}
