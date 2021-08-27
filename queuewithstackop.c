#include<stdio.h>
#include<stdlib.h>

void enqueue();
void dequeue();
void display();
void create();
void push1(int);
void push2(int);
int pop1();
int pop2();
int s1[500], s2[500];
int top1 = -1, top2 = -1;
int count = 0;


int main()
{
int choice;
printf("\n Akshat Behera 221810305002");
printf("\n IDE LAB 1st Program");
printf("\nQuueue using stack operations\n\n");
printf("\n1.Enqueue");
printf("\n2.Dequeue");
printf("\n3.Display");
printf("\n4.Exit");
printf("\n");
create();
while (1)
{
printf("\nEnter your choice : ");
scanf("%d", &choice);
switch (choice)
{
case 1:
enqueue();
break;
case 2:
dequeue();
break;
case 3:
display();
break;
case 4:
exit(0);
default:
printf("\nThis is a Wrong Choice\n");
}
}
}


void create()
{
top1 = top2 = -1;
}


void push1(int element)
{
s1[++top1] = element; 
}


int pop1()
{
return(s1[top1--]); 
}


void push2(int element)
{
s2[++top2] = element; 
}


int pop2()
{
return(s2[top2--]); 
}


void enqueue()
{
int value, i;
printf("Enter the value : ");
scanf("%d", &value);
push1(value); 
count++;
}


void dequeue()
{
int i;
for (i = 0;i <= count;i++)
{
push2(pop1()); 
}
pop2(); 
count--;
for (i = 0;i <= count;i++)
{
push1(pop2()); 
}
}


void display()
{
int i;
if(top1 == -1)
{
printf("\nthe queue is EMPTY \n");
}
else
{
printf("\nElements present in the Queue : ");
for (i = 0;i <= top1;i++)
{
printf(" %d ", s1[i]);
}
printf("\n");
}
}