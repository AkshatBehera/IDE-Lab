n = int(input("Enter nth "))  
  
for x in range(0,n + 1):  
   if x > 1:  
       for i in range(2,x):  
           if (x % i) == 0:  
               break  
       else:  
           print(x)