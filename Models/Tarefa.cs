using System;

namespace ApiRotina.Models
{


public class Tarefa {
    public int Id { get; set; }
    public String nome { get; set; }
    public int horario { get; set; }
    public string descricao { get; set; }
    public bool Concluida { get; set;}

    // Construtores, getters e setters

    /*public Tarefa(int Id, String nome, int horario, string descricao, bool Concluida) {
        this.Id = Id;
        this.nome = nome;
        this.horario = horario;
        this.descricao = descricao;
        this.Concluida = Concluida;
    }*/

    // Getters e Setters
}
}