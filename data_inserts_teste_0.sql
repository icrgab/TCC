-- Usar a base de dados
USE DATAtcc;

-- Inserir dados na tabela usuario
INSERT INTO usuario (emailusuario, senhausuario, recmail, nomeusuario, telefoneusuario) 
VALUES 
('user1@example.com', 'password1', 'rec1@example.com', 'Usuario Um', '123456789'),
('user2@example.com', 'password2', 'rec2@example.com', 'Usuario Dois', '987654321');

-- Inserir dados na tabela documento
INSERT INTO documento (caminhodocumento, documentonome, idusuario)
VALUES 
('caminho/para/documento1.pptx', 'Documento 1', 1),
('caminho/para/documento2.docx', 'Documento 2', 2);

-- Inserir dados na tabela palavra_chave
INSERT INTO palavra_chave (palavra) 
VALUES 
('chave1'),
('chave2');

-- Inserir dados na tabela localizacao
INSERT INTO localizacao (paragrafo, pagina) 
VALUES 
(1, 1),
(2, 2);

-- Inserir dados na tabela documento_palavra_chave
INSERT INTO documento_palavra_chave (id_documento, id_palavra_chave) 
VALUES 
(1, 1),
(1, 2),
(2, 1);

-- Inserir dados na tabela palavra_chave_localizacao
INSERT INTO palavra_chave_localizacao (id_palavra_chave, id_localizacao) 
VALUES 
(1, 1),
(2, 2);


select * from usuario

select * from documento

--cada usuario tem seus documentos
select * from  documento where idusuario=2;
select * from  documento where idusuario=1;

--
