using System.Reflection;
class system{

static void Insere(int[] q, ref int f, int v){
 q[f] = v;
 f++;   
}
static int Remove(int[] q, ref int i){
    int v = q[i];
    i++;
    return i;

}
//vars
static int MAX = 20;
static int aaa=1;
static int [] fila = new int[20];
static int f_i = 0; //indice de inicio da fila
static int f_f = 0; //indice do final da fila

// system functions
static void fun_1(){
    Console.Write("\nDigite o número do avião: ");
    if (f_f<=20){
        Insere(fila,ref f_f, Convert.ToInt32(Console.ReadLine()));
    }else{
        Console.WriteLine("Fila cheia!");
    }
}
void fun_2(){
    Console.WriteLine("Atualmente existem: " + f_f + " aviões aguardando na fila");
}
void fun_3(){
    Console.WriteLine("O avião " + fila[f_i] + " já vai decolar, _>>>>  " );
    Remove(fila, ref f_i);
}
void fun_4(){
    if (f_f-f_i>0){
        Console.WriteLine("Lista de aviões na fila");
        for(int i=f_i; i<f_f;i++){
            Console.WriteLine("Avião  ("+ i +") : " + fila[i]);
        }
    }
    //Console.WriteLine("Existem atualmente " + (f_f-f_i) + " aviões na fila");
}
void fun_5(){
 Console.WriteLine("O avião " + fila[f_i] + " é o primeiro da fila" );
}

//Menu
static int Menu(){
    Console.WriteLine("\n1 - Adicionar avião na fila de espera para decolagem");
    Console.WriteLine("2 - Consultar a quantidade de aviões aguardando na fila");
    Console.WriteLine("3 - Autorizar a decolagem de um avião na fila");
    Console.WriteLine("4 - Listar número de todos os aviões na fila");
    Console.WriteLine("5 - Consultar o número do primeiro avião na fila");
    Console.Write("\nDigite a opção: ");
    return Convert.ToInt32(Console.ReadLine());
}

static void Main(){
    string[] methods = new string[]{"Inicio","fun_1","fun_2","fun_3","fun_4","fun_5"};
    Console.WriteLine("====== Bem vindo ao sistema áereo ========\n");
    int op = Menu();
    while (op>=1 && op<=5){
        Type type = typeof(system);
            MethodInfo methodInfo = type.GetMethod(methods[op]);
            methodInfo.Invoke(methods[op], null);
        //callback menu
        op = Menu();

    }
}
//start


}
