Creación de imágen con nginx desde cero

docker build -t gonchalo620/nginx-cero:latest .

docker run -d -p 8082:80 gonchalo620/nginx-cero:latest

multiples RUN en una sola línea

RUN apt-get update && apt-get install -y nginx

RUN apt-get update \
    && apt-get install -y nginx