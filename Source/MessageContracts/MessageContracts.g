grammar MessageContracts;

options 
{
	language = 'CSharp2'; 
	output=AST; 
}

tokens 
{
	TypeToken;	
	CommandToken;
	EventToken;
	
	MemberToken;
	BlockToken;
	DisctionaryToken;
	FragmentGroup;
	FragmentEntry;
	FragmentReference;
	ModifierDefinition;
}

@lexer::namespace { MessageContracts }
@parser::namespace { MessageContracts }

program	
	:	declaration+
	;
	
declaration
	: modifier_declaration
	| frag_declaration
	| type_declaration
	;

frag_declaration
    :	'let' ID '=' TYPE ID ';' -> ^(FragmentEntry ID TYPE ID)
    ;  
    
modifier_declaration
	: 'using' Modifier '=' TYPE ';' -> ^(ModifierDefinition TYPE Modifier);
    
	

	
type_declaration
	: ID Modifier? block -> ^(TypeToken ID block Modifier?);
	
member 	
	:	TYPE ID -> ^(MemberToken TYPE ID)
	|	ID -> ^(FragmentReference ID)
	;

	
block
    :   lc='('
            (member (',' member)*)?
        ')'
        -> ^(BlockToken[$lc,"Block"] member*)
    ;    

TYPE   : ('a'..'z'|'A'..'Z'|'_')('a'..'z'|'A'..'Z'|'0'..'9'|'<'|'>'|'['|']')* ;	
	

	
	
Modifier
	: '?'
	| '!'
	| ';'
	;


ID  :	('a'..'z'|'A'..'Z'|'_')('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ;

INT :	'0'..'9'+;   


COMMENT
    :   '//' ~('\n'|'\r')* '\r'? '\n' {$channel=Hidden;}
    |   '/*' ( options {greedy=false;} : . )* '*/' {$channel=Hidden;}
    ;

WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        ) {$channel=Hidden;}
    ;  