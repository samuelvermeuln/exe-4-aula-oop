using System;
/* 
4 --- 
Classe Pessoa: Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura

Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.
*/
class pessoa {
  string nome;
  int idade;
  float peso, altura;

  public void Envelhercer (){

  }

  public float RetornaEnvelhecer (){
    return envelhece;
  }

  public void Engordar (){

  }

  public float RetornaEngordar (){
    return gordo;
  }

  public void Emagrecer (){

  }

  public float RetornaEmagrecer(){
    return emagrece;
  }

  public void Crescer (){
    if (idade < 21)
    cresce = cresce + 0.5;
  }

  public float RetornaCrescer (){
    return cresce;
  }


}

