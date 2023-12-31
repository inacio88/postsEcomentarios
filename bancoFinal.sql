PGDMP         %                {            banco1    15.3    15.3                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16394    banco1    DATABASE     }   CREATE DATABASE banco1 WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Portuguese_Brazil.1252';
    DROP DATABASE banco1;
                postgres    false            �            1259    16462 
   comentario    TABLE     �   CREATE TABLE public.comentario (
    comentario_id integer NOT NULL,
    post_id integer,
    texto text,
    usuario_id integer
);
    DROP TABLE public.comentario;
       public         heap    postgres    false            �            1259    16461    comentario_comentario_id_seq    SEQUENCE     �   ALTER TABLE public.comentario ALTER COLUMN comentario_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.comentario_comentario_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            �            1259    16449    post    TABLE     c   CREATE TABLE public.post (
    post_id integer NOT NULL,
    usuario_id integer,
    texto text
);
    DROP TABLE public.post;
       public         heap    postgres    false            �            1259    16448    post_post_id_seq    SEQUENCE     �   ALTER TABLE public.post ALTER COLUMN post_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.post_post_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    217            �            1259    16433    usuario    TABLE     �   CREATE TABLE public.usuario (
    usuario_id integer NOT NULL,
    nome character varying(255) NOT NULL,
    email character varying(255) NOT NULL
);
    DROP TABLE public.usuario;
       public         heap    postgres    false            �            1259    16432    usuario_usuario_id_seq    SEQUENCE     �   ALTER TABLE public.usuario ALTER COLUMN usuario_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.usuario_usuario_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    215                      0    16462 
   comentario 
   TABLE DATA           O   COPY public.comentario (comentario_id, post_id, texto, usuario_id) FROM stdin;
    public          postgres    false    219   �       	          0    16449    post 
   TABLE DATA           :   COPY public.post (post_id, usuario_id, texto) FROM stdin;
    public          postgres    false    217                    0    16433    usuario 
   TABLE DATA           :   COPY public.usuario (usuario_id, nome, email) FROM stdin;
    public          postgres    false    215   N                  0    0    comentario_comentario_id_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.comentario_comentario_id_seq', 7, true);
          public          postgres    false    218                       0    0    post_post_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.post_post_id_seq', 4, true);
          public          postgres    false    216                       0    0    usuario_usuario_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.usuario_usuario_id_seq', 20, true);
          public          postgres    false    214            t           2606    16468    comentario comentario_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.comentario
    ADD CONSTRAINT comentario_pkey PRIMARY KEY (comentario_id);
 D   ALTER TABLE ONLY public.comentario DROP CONSTRAINT comentario_pkey;
       public            postgres    false    219            r           2606    16455    post post_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.post
    ADD CONSTRAINT post_pkey PRIMARY KEY (post_id);
 8   ALTER TABLE ONLY public.post DROP CONSTRAINT post_pkey;
       public            postgres    false    217            p           2606    16439    usuario usuario_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (usuario_id);
 >   ALTER TABLE ONLY public.usuario DROP CONSTRAINT usuario_pkey;
       public            postgres    false    215            v           2606    16469    comentario fk_post    FK CONSTRAINT     u   ALTER TABLE ONLY public.comentario
    ADD CONSTRAINT fk_post FOREIGN KEY (post_id) REFERENCES public.post(post_id);
 <   ALTER TABLE ONLY public.comentario DROP CONSTRAINT fk_post;
       public          postgres    false    219    217    3186            u           2606    16456    post fk_usuario    FK CONSTRAINT     {   ALTER TABLE ONLY public.post
    ADD CONSTRAINT fk_usuario FOREIGN KEY (usuario_id) REFERENCES public.usuario(usuario_id);
 9   ALTER TABLE ONLY public.post DROP CONSTRAINT fk_usuario;
       public          postgres    false    3184    215    217            w           2606    24595    comentario fk_usuario    FK CONSTRAINT     �   ALTER TABLE ONLY public.comentario
    ADD CONSTRAINT fk_usuario FOREIGN KEY (usuario_id) REFERENCES public.usuario(usuario_id) NOT VALID;
 ?   ALTER TABLE ONLY public.comentario DROP CONSTRAINT fk_usuario;
       public          postgres    false    215    219    3184               8   x�3�4�t��U(H,JT(��M,R(�UH��O��I,IU(,M�+IU�44����� thj      	   :   x�3�4���I�Q�M-U((��M�,�W(�/.�2�42�,,MUH�LTH+������� �~         l   x�3�LN��/*�,�Or�M���K���2���O� 1��1�W~F'�kh��șS�Y\�eh��wxarf>gf^"�B�dh	�R�	&��7 ��XX
T�"���� M/�     