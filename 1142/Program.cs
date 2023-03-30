int linha = Convert.ToInt32(Console.ReadLine());
int val_um = 1;
int val_dois;
int val_tres;


for(int i = 0; i < linha; i++){

    val_dois = 1 + val_um;
    val_tres = 1 + val_dois;

    Console.WriteLine($"{val_um} {val_dois} {val_tres} PUM");

    val_um = 2 + val_tres;
}
