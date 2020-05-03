---
description: >-
  En esta pagina daré una breve descripción general del funcionamiento del
  proyecto y una descripción de la funcionalidad de las clases, métodos, y otros
  elementos.
---

# RogueLike

Mi juego se basa en una simple recolección de frutas que tiene que hacer el personaje si quiere salir del laberinto en el que esta encerrado. Funciona por  la generación de un mapa con un doble arrays, un personaje que se mueve por este mapa, objetos y trampas que se ponen en los hueco donde hay suelo. Las clases mas importantes que he utilizado son:

Program: Aquí aplicamos los métodos mas importantes para que se ejecute el juego.

Jugador: Creamos nuestro personaje le damos valores y le aplicamos métodos, ademas de darle uso para que interactue con el juego. Entre los método del jugador encontramos el método mueve\(\), este permite que le asignemos una teclas para que active el movimiento del personaje.

Mapa: Generamos un mapa con diferentes métodos y le aplicamos otras clases para que este haga e base o plantilla para que nosotros podamos jugar.

Bolsa: Esta clase es la raíz para los diferentes objetos que vayamos a poner.

Celda: Con esta clase asignamos color y forma a los elementos del mapa. En la celda se aplica una interfaz para darle un funcionamiento extra a x tipos de casillas.

Material: Decidimos que es es cada celda en el mapa.

