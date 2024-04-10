//se va a realizar una red social donde los usuarios van a tener nombres, apellidos y correo, todas esta informacion va hacer privada, ademas tiene la posibilidad de agregar
// amigos y de entregar el nombre completo y eviar un mensaje privado, la forma de mostrar
// el mensaje privado es: el nombre completo y se envia mensaje a: y el nombre completo de quien lo recibie: y el mensaje.

//nota: usar una clase d etipo usuario, usar una interfaz y crear cada uno en archivo independiente.

using RR.src.interfaces;
using RR.src.clases;

Usuario usuario_uno = new Usuario("Pepe","Robamelo","wwww");
Usuario usuario_dos = new Usuario("Yua","Robamelo","wwwdw");

usuario_uno.agregarAmigos(usuario_dos);
usuario_uno.enviarMensaje(usuario_dos,"Hola");


