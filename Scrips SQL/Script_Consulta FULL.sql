use Telefonia
SELECT 
    CONCAT(TRIM(m.cod_dept), TRIM(m.codigo)) AS INDICATIVO, 
    m.nombre AS Municipio, 
    d.nombre AS Departamento 
FROM 
    Municipios m
INNER JOIN 
    Departamento d 
ON 
    TRIM(m.cod_dept) = TRIM(d.codigo)
WHERE 
    CONCAT(TRIM(m.cod_dept), TRIM(m.codigo)) LIKE '%01020%'

