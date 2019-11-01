FROM mysql:5.6

# Copy the database initialize script: 
# Contents of /docker-entrypoint-initdb.d are run on mysqld startup
ADD  initdb/ /docker-entrypoint-initdb.d/

# Default values for passwords and database name. Can be overridden on docker run
# ENV MYSQL_ROOT_PASSWORD=my-secret-pw # Not defaulted for security reasons!
ENV MYSQL_DATABASE=basedatos
ENV MYSQL_USER=usuario
ENV MYSQL_PASSWORD=contrasena