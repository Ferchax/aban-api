Indicaciones para correr el proyecto en Visual Studio Code:

1. Clonar el repositorio con el comando "git clone https://github.com/Ferchax/aban-api.git"
2. Cambiar al directorio del proyecto con el comando change directory "cd aban-api/backend/abanAPI"
3. Parados en el directorio "aban-api/backend/abanAPI" abrir el VS Code con "code ."
4. Abrir el archivo appsettings.json y en DefaultConnection modificar el valor de variable Server poniendo ahi su servidor.
5. Abrir la terminal de VS Code, si estas en Windows puede ser con "Control + Shift + `"
6. Ejecutar el comando "dotnet watch run" el cual se ocupara de instalar las dependencias y levantar la db si no existe y aplicar el seed, para luego levantar el swagger con todos los endpoints.


NOTA: Necesitamos tener instaladas las siguientes 2 extensiones para VS Code:
![image](https://github.com/Ferchax/aban-api/assets/10538408/559d15f4-3575-4230-958a-1f622e521cfd)

Indicaciones para correr el proyecto en Visual Studio 2022:

1. Clonar el repositorio con el comando "git clone https://github.com/Ferchax/aban-api.git"
2. Entrar al directorio de la solucion, por defecto es "aban-api" y ejecutar la solucion (aban-api.sln)
3. Correr el proyecto.
