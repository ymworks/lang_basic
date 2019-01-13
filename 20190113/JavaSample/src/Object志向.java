
public class Object志向 {

	public static void main(String[] args) {
		goSearch();
		clickNext();
		closeTab();
	}

	private static void goSearch() {
		System.out.println("Go search");
	}

	private static void closeTab() {
		System.out.println("Close tab");
	}
	
	private static void clickNext() {
		System.out.println("Click next");
	}
	
	// 順番が大事になるのが、手続き型プログラミング。
	
	// オブジェクト指向のキーワード：カプセル化、一つ一つのカプセルが、自分だけの役割を持っている。
}