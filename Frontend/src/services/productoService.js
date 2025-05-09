import { mostrarMensaje } from "../helpers/mostrarMensaje.js";

export async function crearProducto(data) {
    try {
        const respuesta = await fetch("http://localhost:5031/api/producto", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(data),
        });
        if (respuesta.ok) {
            mostrarMensaje("Producto registrado exitosamente.", "exito");

            document.getElementById("formularioProducto").reset();
        } else {
            const error = await respuesta.json();
            mostrarMensaje(
                `Error: ${
                    error.message || "No se pudo registrar el producto."
                }`,
                "error"
            );
        }
    } catch (error) {
        console.error("Error al enviar los datos:", error);
        mostrarMensaje("Error al conectar con el servidor.", "error");
    }
}

export async function obtenerProductos() {
    try {
        const respuesta = await fetch("http://localhost:5031/api/producto", {
            method: "GET",
            headers: { "Content-Type": "application/json" },
        });
        if (respuesta.ok) {
            return await respuesta.json();
        } else {
            mostrarMensaje("Error al obtener productos.", "error");
            return [];
        }
    } catch (error) {
        console.error("Error al conectar con el servidor:", error);
        mostrarMensaje("Error al conectar con el servidor.", "error");
        return [];
    }
}

export async function obtenerProductoPorId(id) {
    try {
        const respuesta = await fetch(
            `http://localhost:5031/api/producto/${id}`,
            {
                method: "GET",
                headers: { "Content-Type": "application/json" },
            }
        );
        if (respuesta.ok) {
            return await respuesta.json();
        } else {
            mostrarMensaje("Error al obtener el producto.", "error");
            return null;
        }
    } catch (error) {
        console.error("Error al conectar con el servidor:", error);
        mostrarMensaje("Error al conectar con el servidor.", "error");
        return null;
    }
}

export async function actualizarProducto(data) {
    try {
        const respuesta = await fetch(
            `http://localhost:5031/api/producto/${data.id}`,
            {
                method: "PUT",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(data),
            }
        );

        if (!respuesta.ok) {
            if (respuesta.status === 404) {
                throw new Error("El producto no existe o ya fue eliminado.");
            }

            const error = await respuesta.json();
            throw new Error(`Error al actualizar: ${JSON.stringify(error)}`);
        }
    } catch (error) {
        console.error("Error al enviar los datos:", error);
        throw error;
    }
}

export async function eliminarProducto(id) {
    try {
        const respuesta = await fetch(
            `http://localhost:5031/api/producto/${id}`,
            {
                method: "DELETE",
                headers: { "Content-Type": "application/json" },
            }
        );
        if (respuesta.ok) {
            mostrarMensaje("Producto eliminado exitosamente.", "exito");
        } else {
            const error = await respuesta.json();
            mostrarMensaje(
                `Error: ${error.message || "No se pudo eliminar el producto."}`,
                "error"
            );
        }
    } catch (error) {
        console.error("Error al enviar los datos:", error);
        mostrarMensaje("Error al conectar con el servidor.", "error");
    }
}
