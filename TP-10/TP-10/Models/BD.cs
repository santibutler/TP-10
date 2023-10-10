using System.Data.SqlClient;
using Dapper;
namespace TP9;

public class BD{

    public static List<Serie> MostrarSeries(){
        Serie serie = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Series";
            serie = db.QueryFirstOrDefault<Serie>(sql).ToList();
        }
        return serie;
    }

    
//-------------------------------

    public static List<Serie> MostrarInfoSerie(string id){
        Serie serie = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Series WHERE IdSerie = pIdSerie";
            serie = db.Query<Serie>(sql, new {pIdSerie = id});
        }
        return serie;
    }

    public static List<Actor> MostrarInfoActor(string id){
        Actor actor = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Actores WHERE IdActor = pIdActor";
            actor = db.Query<Actor>(sql, new {pIdActor = id});
        }
        return actor;
    }

    public static List<Temporada> MostrarInfoTemporada(string id){
        Temporada temporada = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Temporadas WHERE IdTemporada = pIdTemporada";
            temporada = db.Query<Temporada>(sql, new {pIdTemporada = id});
        }
        return temporada;
    }

}