FROM nginx:latest
RUN pwd
RUN mkdir carpeta-creada
RUN ls
COPY un-archivo.txt otro-nombre-si-quiere.txt
ADD carpeta-para-copiar /var/www
COPY carpeta-para-copiar /var/www/carpeta-entera
RUN ls
