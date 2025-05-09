import {
    obtenerProductoPorId,
    eliminarProducto,
} from "../services/productoService.js";
import { mostrarMensaje } from "./mostrarMensaje.js";

export function asignarEventosBotones(productoItem) {
    const btnEditar = productoItem.querySelector(".btn-editar");
    const btnEliminar = productoItem.querySelector(".btn-eliminar");

    btnEditar.addEventListener("click", async (evento) => {
        const id = evento.target.getAttribute("data-id");
        const producto = await obtenerProductoPorId(id);

        document.getElementById("nombre").value = producto.nombre;
        document.getElementById("precioUnitario").value =
            producto.precioUnitario;
        document.getElementById("descripcion").value = producto.descripcion;

        const botonSubmit = document.querySelector(
            "#formularioProducto button[type='submit']"
        );
        botonSubmit.textContent = "Actualizar Producto";
        botonSubmit.setAttribute("data-id", id);
    });

    btnEliminar.addEventListener("click", async (evento) => {
        const id = evento.target.getAttribute("data-id");
        try {
            await eliminarProducto(id);
            productoItem.remove(); // Eliminar el producto del DOM
            mostrarMensaje("Producto eliminado exitosamente.", "exito");
        } catch (error) {
            console.error("Error al eliminar el producto:", error);
            mostrarMensaje("No se pudo eliminar el producto.", "error");
        }
    });
}
