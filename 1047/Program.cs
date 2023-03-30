// See https://aka.ms/new-console-template for more information

string[] horarios = Console.ReadLine().Split(' ');

    int hi = int.Parse(horarios[0]);
    int mi = int.Parse(horarios[1]);
    int hf = int.Parse(horarios[2]);
    int mf = int.Parse(horarios[3]);
    int hora;
    int minutos;
    
      if(hf > hi){
        hora = hf - hi;
        Console.Write($"O JOGO DUROU {hora} HORA(S) E ");
      } else if(hf < hi){
        hora = hf - hi;
        hora = Math.Abs(hora);
        Console.Write($"O JOGO DUROU {hora} HORA(S) E ");

      }else{
        Console.Write($"O JOGO DUROU 24 HORA(S) E ");
      }

    if(mi > mf){
        minutos = (60 - mi) + mf;
    }else{
        minutos = mf - mi;
    }
    
    Console.Write($"{minutos} MINUTO(S)");
