void Insere(ref char[] p, ref int t, char v){
    p[t] = v;
    t++;
}
bool EstaVazia(ref int t){
    if (t!=0){
        return true;
    }else{
        return false;
    }
}

char Remove( ref char[]p, ref int t){
    t = t-1;
    return p[t];
} 

Console.Write("Digite uma frase: ");
string frase = Console.ReadLine();
frase+=' ';
int t=0; //indice da pilha
int i=0; // percorre frase
int qtd_c = frase.Length; // quantidade de caracteres da frase
char[] pilha = new char[qtd_c];

while ( i < qtd_c ){
    if (frase[i]!=' '){
        
       Insere(ref pilha, ref t, frase[i]);
    }else{
       //exibi todos dentro da pilha, e adiciona um espaço, remove todos da pilha
       while( t> 0 ){
            char letra = Remove(ref pilha, ref t);
            Console.Write(letra);
       }
       Console.Write(" ");
       
       
    }
    i++;
}



