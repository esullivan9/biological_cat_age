#Ask for the age of the user's cat.
print('Enter the age of your cat (in years): ', end ="")
#Convert the input to a float.
age = (float)(input())

#Determine which formula to use based on the user's input, 
#calculate the "actual" age of their cat, then print the
#result of the calculation to the screen.
if (age >= 0.0) and (age <= 1.0):
	convertedage = 16.6364 * age
	print('Your cat is %f years old.' %(convertedage))
elif (age > 1) and (age < 2):
	convertedage = 6.6364 * age + 10
	print('Your cat is %f years old.' %(convertedage))
elif (age >= 2):
	convertedage = 4.1364 * (age + 3.62634)
	print('Your cat is %f years old.' %(convertedage))