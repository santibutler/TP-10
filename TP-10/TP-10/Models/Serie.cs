public class Serie{
    public int IdSerie{get;set;}
    public string Nombre {get;set;}
    public DateTime AnioInicio {get;set;}
    public string Sinopsis {get;set;}
    public string ImagenSerie {get;set;}

public Serie(){}

public Serie(int pIdSerie, string pNombre, DateTime pAnioInicio, string pSinopsis, string pImagenSerie){
    IdSerie=pIdSerie;
    Nombre=pNombre;
    AnioInicio=pAnioInicio;
    Sinopsis=pSinopsis;
    ImagenSerie=pImagenSerie;
}
}