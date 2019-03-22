import java.util.Scanner;


public class PA6a {
	
	static final String E_YEAR = "The year must be positive!";
	static final String E_DAY = "The day of January 1st must be between 0 and 6!";

	public static boolean isLeapYear(int year) 
	{
		boolean leap = false;
        if(year % 4 == 0)
        {
            if( year % 100 == 0)
            {
                if ( year % 400 == 0)
                    leap = true;
                else
                    leap = false;
            }
            else
                leap = true;
        }
        else
            leap = false;
		
		return leap;
	}
	
	public static void printMonth(String month, int startDay, int numDays)
	{
		
		int[] array = new int[numDays + 6];
		
		for(int I = startDay; I < array.length; I++) array[I] = I - (startDay - 1); // Initialize month array
		
		System.out.printf("%s%n",month);
	
		for(int day = 0; day <= numDays + (startDay - 1); day++)
		{
			if(array[day] == 0)
				System.out.printf("%3s", " ");
			else
				System.out.printf("%3s", array[day]); // Print evenly spaced days
			
			if((day + 1) % 7 == 0)  System.out.printf("%n"); // Add a new line at the end of the week
		}
		
		System.out.printf("%n");
		// print a newline if the month does not end on a sunday
		if(numDays == 28 && addDay(startDay, -1) != 6) System.out.printf("%n");
		if(numDays == 29 && addDay(startDay, 0) != 6) System.out.printf("%n");
		if(numDays == 30 && addDay(startDay, 1) != 6) System.out.printf("%n");
		if(numDays == 31 && addDay(startDay, 2) != 6) System.out.printf("%n");		
		
		
	}
	
	public static int addDay(int dayA,int dayB)
	{
		
		int output = dayA + dayB;
		if(output > 6) output = output - 7;
		if(output < 0) output = output + 7;
		return output;
	}
	
	public static void main(String[] args) 
	{
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("Enter the year: ");
		int year = input.nextInt();
		
		System.out.print("Enter the day of the week of January 1st (0=Sunday, 1=Monday, ... 6=Saturday): ");
		int firstDay = input.nextInt(); 
		
		if(year < 0)
		{
			System.out.println(E_YEAR);
			System.exit(1);
		}
		if(firstDay < 0 || firstDay > 6)
		{
			System.out.println(E_DAY);
			System.exit(1);
		}
		
		String[] months = {"January","February","March"
							,"April","May","June"
							,"July","August","September"
							,"October","November","December"
							};
		
		int[] days = {31, (isLeapYear(year) ? 1 : 0) + 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		
		for(int I = 0; I < days.length; I++) // Determine when the months end
		{
			
			printMonth(months[I], firstDay, days[I]);
			
			if(days[I] == 28) firstDay = addDay(firstDay, 0);
			if(days[I] == 29) firstDay = addDay(firstDay, 1);
			if(days[I] == 30) firstDay = addDay(firstDay, 2);
			if(days[I] == 31) firstDay = addDay(firstDay, 3);
			
			
		}
		
		input.close();


	}

}
