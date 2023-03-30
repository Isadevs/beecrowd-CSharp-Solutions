// See https://aka.ms/new-console-template for more information
int entrada = Convert.ToInt32(Console.ReadLine());
int val_in = 0;
int val_out = 0 ;

for(int i = 0; i < entrada ; i++){
    int valor = Convert.ToInt32(Console.ReadLine());

        if(valor >= 10 && valor <=20){
            val_in++;
        }else{
            val_out++;
        }
}

Console.WriteLine($"{val_in} in");
Console.WriteLine($"{val_out} out");


/*VALIDADO*/