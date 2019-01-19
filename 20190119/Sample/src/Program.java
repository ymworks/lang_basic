
public class Program {
	public static void main(String[] args) {
		UserInfo user = new UserInfo("takeuchi", 21);
		
		String name = user.getName();
		int age = user.getAge();
		// 名前は文字列(String)、歳は数字(integer)
		
		System.out.println(user.toString());
		System.out.println(name);
		System.out.println(age);
		
		//UserInfo another = new UserInfo("kim", 29);
		UserInfo another = new UserInfo("takeuchi", 21);
		
		String temp = "21";
		
		System.out.println(user.getName().equals(temp));
	}
}
