public class Actor{
    public int IdActor {get;set;}
    public int IdSerie {get;set;}
    public string Nombre {get;set;}

public Actor(){}

public Actor(int pIdActor, int pIdSerie, string pNombre){
    IdActor = pIdActor;
    IdSerie = pIdSerie;
    Nombre = pNombre;

}
}