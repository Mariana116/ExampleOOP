namespace RR.src.clases;

using RR.src.interfaces;

public class Usuario:IUsuario{
    private string nombres {get;set;}
    private string apellidos {get;set;}
    private string correo {get;set;}
    private List<IUsuario> amigos = new List<IUsuario>();

    public Usuario(string nombres,string apellidos,string correo){
        this.nombres= nombres;
        this.apellidos=apellidos;
        this.correo=correo;
    }

    public string nombreCompleto(){
            return this.nombres + "" + this.apellidos;
    }

    public void agregarAmigos (IUsuario amigo){
        this.amigos.Add(amigo);
    }

    public void enviarMensaje(IUsuario amigo, string mensaje){
        Console.WriteLine(this.nombreCompleto()+" le envia a: "+ amigo.nombreCompleto() +" mensaje: " + mensaje);
    }
}
