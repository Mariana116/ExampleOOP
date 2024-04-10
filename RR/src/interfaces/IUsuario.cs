namespace RR.src.interfaces;

public interface IUsuario{
    public string nombreCompleto();
    public void agregarAmigos(IUsuario amigo);
    public void enviarMensaje(IUsuario amigo, string mensaje);
}

