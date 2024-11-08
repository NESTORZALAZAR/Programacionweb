PGDMP      #            	    |           parcial2    16.4    16.4     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16398    parcial2    DATABASE     �   CREATE DATABASE parcial2 WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_United States.1252';
    DROP DATABASE parcial2;
                postgres    false            �            1259    16399    ciudad    TABLE     o   CREATE TABLE public.ciudad (
    ciu_codigo integer NOT NULL,
    ciu_descri character varying(40) NOT NULL
);
    DROP TABLE public.ciudad;
       public         heap    postgres    false            �            1259    16404    cliente    TABLE       CREATE TABLE public.cliente (
    ci_codigo integer NOT NULL,
    ci_cedula integer NOT NULL,
    ci_nombre character varying(40) NOT NULL,
    ci_apellido character varying(40) NOT NULL,
    ci_ciudad integer NOT NULL,
    ci_tele integer,
    ci_dire character varying(80)
);
    DROP TABLE public.cliente;
       public         heap    postgres    false            �            1259    16419    producto    TABLE     1  CREATE TABLE public.producto (
    pro_codigo integer NOT NULL,
    pro_codbarra integer NOT NULL,
    pro_descr character varying(40) NOT NULL,
    pro_cantidad integer NOT NULL,
    pro_precio_compra numeric(10,2),
    pro_precio_venta numeric(10,2),
    pro_fecha date,
    pro_codigo_prove integer
);
    DROP TABLE public.producto;
       public         heap    postgres    false            �            1259    16414    usuario    TABLE     �   CREATE TABLE public.usuario (
    usu_codigo integer NOT NULL,
    usu_nombre character varying(30) NOT NULL,
    usu_password character varying(30) NOT NULL,
    usu_nivel character varying(30) NOT NULL
);
    DROP TABLE public.usuario;
       public         heap    postgres    false            �          0    16399    ciudad 
   TABLE DATA           8   COPY public.ciudad (ciu_codigo, ciu_descri) FROM stdin;
    public          postgres    false    215   U       �          0    16404    cliente 
   TABLE DATA           l   COPY public.cliente (ci_codigo, ci_cedula, ci_nombre, ci_apellido, ci_ciudad, ci_tele, ci_dire) FROM stdin;
    public          postgres    false    216   �       �          0    16419    producto 
   TABLE DATA           �   COPY public.producto (pro_codigo, pro_codbarra, pro_descr, pro_cantidad, pro_precio_compra, pro_precio_venta, pro_fecha, pro_codigo_prove) FROM stdin;
    public          postgres    false    218   �       �          0    16414    usuario 
   TABLE DATA           R   COPY public.usuario (usu_codigo, usu_nombre, usu_password, usu_nivel) FROM stdin;
    public          postgres    false    217   y       \           2606    16403    ciudad ciudad_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.ciudad
    ADD CONSTRAINT ciudad_pkey PRIMARY KEY (ciu_codigo);
 <   ALTER TABLE ONLY public.ciudad DROP CONSTRAINT ciudad_pkey;
       public            postgres    false    215            ^           2606    16408    cliente cliente_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pkey PRIMARY KEY (ci_codigo);
 >   ALTER TABLE ONLY public.cliente DROP CONSTRAINT cliente_pkey;
       public            postgres    false    216            b           2606    16423    producto producto_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.producto
    ADD CONSTRAINT producto_pkey PRIMARY KEY (pro_codigo);
 @   ALTER TABLE ONLY public.producto DROP CONSTRAINT producto_pkey;
       public            postgres    false    218            `           2606    16418    usuario usuario_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (usu_codigo);
 >   ALTER TABLE ONLY public.usuario DROP CONSTRAINT usuario_pkey;
       public            postgres    false    217            c           2606    16409    cliente cliente_ci_ciudad_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_ci_ciudad_fkey FOREIGN KEY (ci_ciudad) REFERENCES public.ciudad(ciu_codigo);
 H   ALTER TABLE ONLY public.cliente DROP CONSTRAINT cliente_ci_ciudad_fkey;
       public          postgres    false    4700    215    216            �   L   x�3�t,.�K�<�9�ˈ�9�4%1E!%5G���$�˘�5/9�(/���ӧ��4�˔381O�'�(5�*�+F��� y�=      �   �   x�5�1n�0Eg�<AI�l�IPH4�܅m=P�@�3�63xz]�t��|��i�ƒ��'�p,��]ACSWޑ56�/^��p�rgZ��8���9�k�"h*g�!_ÎC�����(ʂ��XKr�!��b�G��2GN~{x�FF�/'�kE���&2��,0	,��d�oB*����G��F9xx�C;��:�9��DWÖs��~�.'��RJ��KE      �   �   x�U��N1���S���q~j
Z$:DD+-�����hy1r������7�x1e�ԩ�ex�������&���������[G�d9Š^�pU^ƥ~�m^���z���-�����Ew�X�q����X�܁����N!��{��!\���Zό��o�:7$�����-;x��1��rθ}�ٗ�9���{�Z������� Lt      �   %   x�3�LL����4426�t13�K�S�b���� �j	#     