public class Temporada{
    public int IdTemporada{get;set;}
    public int IdSerie {get;set;}
    public int NumeroTemporada {get;set;}
    public string TituloTemporada {get;set;}

public Temporada(){}

public Temporada(int pIdTemporada, string pIdSerie, int pNumeroTemporada, string pTituloTemporada){
    IdTemporada=pIdTemporada;
    IdSerie=pIdSerie;
    NumeroTemporada=pNumeroTemporada;
    TituloTemporada=pTituloTemporada;
}
}