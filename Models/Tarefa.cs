using System;

namespace ApiRotina.Models
{


public class Tarefa {
    public int Id { get; set; }
    public String nome { get; set; }
    public String horario { get; set; }
    public String descricao { get; set; }
    public String Concluida { get; set;}

    // Construtores, getters e setters

    public Tarefa(int Id, String nome, String horario, String descricao) {
        this.Id = Id;
        this.nome = nome;
        this.horario = horario;
        this.descricao = descricao;
        this.Concluida = Concluida;
    }

    // Getters e Setters
}
}