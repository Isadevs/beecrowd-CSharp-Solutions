// See https://aka.ms/new-console-template for more information


int I = 1;
int J1 = 7;
int J2 = 6;
int J3 = 5;

for(int i = 0; i < 5; i++){

    Console.WriteLine($"I={I} J={J1}");
    Console.WriteLine($"I={I} J={J2}");
    Console.WriteLine($"I={I} J={J3}");

    J1 = J1 + 2;
    J2 = J2 + 2;
    J3 = J3 + 2;
     I = I + 2;

}