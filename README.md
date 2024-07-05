# CharacterCounter
> # What is the programm:
- This app helps us to count how much the letters, numbers and characters in sentence
> ## What codes do we used:
> - the main code in this app is "foreach", by using foreach we can count the simbols in enterd sentence:
```cs
Print("Welcome to app");
Console.Write("Enter the text: ");
string userInput = Console.ReadLine();

int count = 0;
int count1 = 0;
int count2 = 0;
          
foreach (char item in userInput)
{
    if (!char.IsLetterOrDigit(item))
    {
        count2++;
    }
    else if (char.IsDigit(item)) //(item is >= '0' and  <= '9')
    {
        count++;
    }
    else if (char.IsLetter(item))//(item >= 'a' && item <= 'z' || item >= 'A' && item <= 'Z')
    {
        count1++;
    }
```
- And also in this code we used short codes rather than using many simbols:
- ```cs
  else if (char.IsLetter(item))//(item >= 'a' && item <= 'z' || item >= 'A' && item <= 'Z')
  ```
  
   
