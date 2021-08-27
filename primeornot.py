def prime(n):  
 
    if n > 1:  
       
        for j in range(2, int(n/2) + 1):  
 
            if (n % j) == 0:  
                print(n, "is not a prime number")  
                break  

        else:  
            print(n, "is a prime number")  

    else:  
        print(n, "is not a prime number")  
 
n = int(input("Enter an input number: "))  

prime(n)  