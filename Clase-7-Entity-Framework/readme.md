#  Clase-7-Practica Entity Framework

## Como generar entidades al agregar nuevas tablas en la Base de Datos
- En la consola de manejo de paquetes, elegir en el combo arriba a la derecha el proyecto donde crear las clases
- Editar el siguiente comando con la connectionstring a su base de datos.
- Ejecutar el comando
`Scaffold-DbContext "Server=.;Database=2022-2C-Enciclopedia-Darwin;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entidades`

## Tarea - Filtro Tipo Especie
- Agregar logica para poder Filtrar por tipo de especie (incluyendo la opcion de todas).
- Este combo debe estar ordenado alfabeticamente
## Intrucciones
- Hacer un fork de este repositorio
- Crear Pull Request contra el repositorio original
