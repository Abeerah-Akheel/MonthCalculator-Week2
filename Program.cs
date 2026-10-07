BuildSwitchStatement();

void BuildSwitchStatement()
{
    Console.WriteLine("Enter a month (1-12):");
    int month = Convert.ToInt32(Console.ReadLine());
    string monthName;

    //The switch statement check the contents of teh month variabe and tehn jumps to the relevant "case" that coressponds to the month number 
    switch (month)
    {
        case 1:
            monthName = "January";
            break;
        case 2:
            monthName = "February";
            break;
        case 3:
            monthName = "March";
            break;
        case 4:
            monthName = "April";
            break;
        case 5:
            monthName = "May";
            break;
        case 6:
            monthName = "June";
            break;
        case 7:
            monthName = "July";
            break;
        case 8:
            monthName = "August";
            break;
        case 9:
            monthName = "September";
            break;
        case 10:
            monthName = "October";
            break;
        case 11:
            monthName = "November";
            break;
        case 12:
            monthName = "December";
            break;
        default:
            monthName = "Invalid Month";
            break;
    }

    // Display the month name to the user
    Console.WriteLine($"Month {month} is the {monthName}");
}