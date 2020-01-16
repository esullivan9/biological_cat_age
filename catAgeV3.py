#Very similar to catAge_python.py, however, this file returns the 
#"actual" age of the cat in years, months, days, hours, minutes 
#and seconds.

#Displays the "actual" age in years, months, days, hours, minutes and seconds.
def convert(catAgeResult):
	years = int(catAgeResult)
	months = 12*float('%.6f'%(catAgeResult - years))
	days = 30.417*float('%.6f'%(months - int(months)))
	hours = 24*float('%.6f'%(days - int(days)))
	minutes = 60*float('%.6f'%(hours - int(hours)))
	seconds = 60*float('%.6f'%(minutes - int(minutes)))

	return '%d years, %d months, %d days, %d hours, %d minutes, %d seconds old.' %(int(years), int(months), int(days), int(hours), int(minutes), int(seconds))

#Determine which formula to use based on the user's input, 
#calculate the "actual" age of their cat, then print the
#result of the calculation to the screen.
def catage(age):
	if (age >= 0.0) and (age <= 1.0):
		convertedage = 16.6364 * age
		return 'Your cat is ' + convert(convertedage)
	elif (age > 1.0) and (age < 2.0):
		convertedage = 6.6364 * age + 10
		return 'Your cat is ' + convert(convertedage)
	elif (age >= 2):
		convertedage = 4.1364 * (age + 3.62634)
		return 'Your cat is ' + convert(convertedage)

#Ask for the age of the user's cat.
print('Enter the age of your cat (in years): ', end="")

#Convert the input to a float.
age = (float)(input())

#Pass the user's cat age into the conversion function
#then print the result to the screen.
print(catage(age))
