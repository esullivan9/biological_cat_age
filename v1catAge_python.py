#Function that calculates the "actual" age of a cat 
#based on the age entered by the user.
def catage(age):
	if (age >= 0.0) and (age <= 1.0):
		convertedage = 16.6364 * age
		return 'Your cat is %f years old.' %(convertedage)
	elif (age > 1) and (age < 2):
		convertedage = 6.6364 * age + 10
		return 'Your cat is %f years old.' %(convertedage)
	elif (age >= 2):
		convertedage = 4.1364 * (age + 3.62634)
		return 'Your cat is %f years old.' %(convertedage)

#Ask for the age of the user's cat.
print('Enter the age of your cat (in years): ', end ="")

#Convert the input to a float.
age = (float)(input())

#Pass the user's cat age into the conversion function
#then print the result to the screen.
print (catage(age))