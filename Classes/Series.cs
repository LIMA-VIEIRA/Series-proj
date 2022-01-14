using System;

namespace Series
{
    public class Serie : EntidadeBase
{
    //ATRIBUTOS
    private Genero  Genero { get; set; }
    private String Titulo { get; set; }
    private string Decrição { get; set; }
    private int Ano { get; set; }
    private bool Excluido { get; set; }
    
    //METODOS
    public Serie(int id, Genero Genero, string titulo, string descricao, int ano)
    {
        this.Id = id;
        this.Genero = Genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;
        this.Excluido = false;
    }
    public override string ToString()
    {
        string retorna = "";
        retorna += "Genero:" + this.Genero + Environment.NewLine;
        retorna += "Titulo:" + this.Titulo + Environment.NewLine;
        retorna += "Descricao:" + this.Descricao + Environment.NewLine;
        retorna += "ANO DE Inicio:" + this.Ano + Environment.NewLine;
        retorna += "Excluido:" + this.Excluido;
        return retorna;
    }
    public string retornaTitulo()
    {
       return this.Titulo;
    }
    public int retornaId()
    {
        return this.Id;
    }
    public bool retornaExcluido()
    {
        return this.Excluido;
    }
    public void Excluir(){
        this.Excluido = true;
    }
}
}