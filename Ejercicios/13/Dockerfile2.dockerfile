FROM httpd:latest
ARG ARGUMENTO=SiNoMePasaNada
RUN echo ${ARGUMENTO}
ARG SINNADA
RUN echo ${SINNADA}
ENV CLAVE=VALOR
RUN echo ${CLAVE}
WORKDIR /var
RUN pwd
EXPOSE 8081
WORKDIR /usr/local/apache2
CMD [ "httpd-foreground" ]