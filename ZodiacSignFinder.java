import java.util.Scanner;


public class ZodiacSignFinder {

	
	public static void main(String[] args) {
		
		Scanner input;
		
		int month;
		int day;
		
		String output;
		
		input = new Scanner(System.in);
		output = new String();
		
		System.out.print("Enter your birth month (1-12): ");
		month = input.nextInt();
		System.out.print("Enter your birth day (1-31): ");
		day = input.nextInt();
		
		if(day > 31 || day < 1) // Check range of days
		{
			System.out.println("Day must be between 1 and 31!");
			System.exit(0);
		}
		if(month < 1 || month > 12) // Check range of months
		{
			System.out.println("Month must be between 1 and 12!");
			System.exit(0);
		}
		
		// Determine zodiac sign 
		if(month == 1 && day >= 20 || month == 2 && day <= 18) output = "an Aquarius";
		else if(month == 2 && day >= 19 || month == 3 && day <= 20) output = "a Pisces";
		else if(month == 3 && day >= 21 || month == 4 && day <= 19) output = "an Aries";
		else if(month == 4 && day >= 20 || month == 5 && day <= 20) output = "a Taurus";
		else if(month == 5 && day >= 21 || month == 6 && day <= 21) output = "a Gemini";
		else if(month == 6 && day >= 22 || month == 7 && day <= 22) output = "a Cancer";
		else if(month == 7 && day >= 23 || month == 8 && day <= 22) output = "a Leo";
		else if(month == 8 && day >= 23 || month == 9 && day <= 22) output = "a Virgo";
		else if(month == 9 && day >= 23 || month == 10 && day <= 22) output = "a Libra";
		else if(month == 10 && day >= 23 || month == 11 && day <= 21) output = "a Scorpio";
		else if(month == 11 && day >= 22 || month == 12 && day <= 21) output = "a Sagittarius";
		else if(month == 12 && day >= 22 || month == 1 && day <= 19) output = "a Capricorn";
		
		
		
		System.out.printf("You are %s!%n",output);
	
	}

}
