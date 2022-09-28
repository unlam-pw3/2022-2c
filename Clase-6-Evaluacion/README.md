#  Clase-6-Ejemplo-Evaluacion "Alquiler de Vehiculos"
## Consigna en clase
1. Al ejecutar la aplciacion esta debe iniciar en un controlador InicioController y accion Bienvenido
2. Agregar un layout que tenga un menu con links fijo y footer de info de alumno
3. Logica. Registrar Alquiler Auto
	Nombre Cliente:
	Modelo Auto:
	Cantidad de dias:
	
	boton (Registrar Alquiler)
	
Precio Alquiler = (cantidad de dias) * (precio diario)

cantidad de dias < 10 => precio diario = 1000
20 > cantidad de dias >= 10 => precio diario = 800
cantidad de dias >= 20 => precio diario = 500

4. Validacion
-Cliente. requerido
-Modelo hasta 20 caracteres. opcional
-Cantidad de dias. Numerico, requerido, mayor o igual a 1 y menor o igual a 365

5. Resultados

#idAlquiler 		Cliente 		Modelo 		Cantidad de dias		Precio Alquiler
1					Pablo			Ford Focus	9						9000
2					Ruben			Ford Fiesta	10						8000
3					Romina			Fiat Palio	20						10000

## Tarea
- Repasar lo visto en clase en las practicas, y estar preparado para realizar un ejercicio similar en 2hs
- Otro repositorio de ejemplo https://github.com/Unlam-pw3-2021-1c/Clase6PracticaEvaluacion

## Intrucciones
- Hacer un fork de este repositorio
- Crear Pull Request contra el repositorio original
