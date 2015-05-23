
'===============================================================================
'  Generated From - VbNet_SQL_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  **
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'MustInherit' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can Override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  Public Class YourObject
'    Inherits _YourObject
'
'  End Class
'
'===============================================================================

' Generated by MyGeneration Version # (1.3.0.3)

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Specialized

Imports MyGeneration.dOOdads

Public MustInherit Class _Tbluser_master
	Inherits SqlClientEntity

		Public Sub New() 
			Me.QuerySource = "Tbluser_master"
			Me.MappingName = "Tbluser_master"
		End Sub

	'=================================================================
	'  Public Overrides Sub AddNew()
	'=================================================================
	'
	'=================================================================
	Public Overrides Sub AddNew()
		MyBase.AddNew()
				
	End Sub
	
	Public Overrides Sub FlushData()
		Me._whereClause = nothing
		Me._aggregateClause = nothing		
		MyBase.FlushData()
	End Sub
	
		
	'=================================================================
	'  	Public Function LoadAll() As Boolean
	'=================================================================
	'  Loads all of the records in the database, and sets the currentRow to the first row
	'=================================================================
	Public Function LoadAll() As Boolean
	
		Dim parameters As ListDictionary = Nothing
		
		
    	Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_Tbluser_masterLoadAll]", parameters)
		
	End Function

	'=================================================================
	' Public Overridable Function LoadByPrimaryKey()  As Boolean
	'=================================================================
	'  Loads a single row of via the primary key
	'=================================================================
	Public Overridable Function LoadByPrimaryKey(ByVal Id As Integer) As Boolean

		Dim parameters As ListDictionary = New ListDictionary()
		parameters.Add(_Tbluser_master.Parameters.Id, Id)

		
		Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_Tbluser_masterLoadByPrimaryKey]", parameters)

	End Function

	#Region "Parameters"
	Protected class Parameters 
		
		Public Shared ReadOnly Property Id As SqlParameter
			Get
				Return New SqlParameter("@Id", SqlDbType.Int, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property Username As SqlParameter
			Get
				Return New SqlParameter("@Username", SqlDbType.VarChar, 50)
			End Get
		End Property
		
		Public Shared ReadOnly Property Password As SqlParameter
			Get
				Return New SqlParameter("@Password", SqlDbType.VarChar, 50)
			End Get
		End Property
		
	End Class
	#End Region	

	#Region "ColumnNames"
	Public class ColumnNames
		
        Public Const Id As String = "id"
        Public Const Username As String = "username"
        Public Const Password As String = "password"

		Shared Public Function ToPropertyName(ByVal columnName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(Id) = _Tbluser_master.PropertyNames.Id
				ht(Username) = _Tbluser_master.PropertyNames.Username
				ht(Password) = _Tbluser_master.PropertyNames.Password

			End If
			
			Return CType(ht(columnName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing		 
	End Class
	#End Region	
	
	#Region "PropertyNames"
	Public class PropertyNames
		
        Public Const Id As String = "Id"
        Public Const Username As String = "Username"
        Public Const Password As String = "Password"

		Shared Public Function ToColumnName(ByVal propertyName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(Id) = _Tbluser_master.ColumnNames.Id
				ht(Username) = _Tbluser_master.ColumnNames.Username
				ht(Password) = _Tbluser_master.ColumnNames.Password

			End If
			
			Return CType(ht(propertyName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing
		
	End Class
	#End Region	
	
	#Region "StringPropertyNames"
	Public class StringPropertyNames
		
        Public Const Id As String = "s_Id"
        Public Const Username As String = "s_Username"
        Public Const Password As String = "s_Password"

	End Class
	#End Region		
	
	#Region "Properties" 
		Public Overridable Property Id As Integer
			Get
				Return MyBase.GetInteger(ColumnNames.Id)
			End Get
			Set(ByVal Value As Integer)
				MyBase.SetInteger(ColumnNames.Id, Value)
			End Set
		End Property

		Public Overridable Property Username As String
			Get
				Return MyBase.GetString(ColumnNames.Username)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.Username, Value)
			End Set
		End Property

		Public Overridable Property Password As String
			Get
				Return MyBase.GetString(ColumnNames.Password)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.Password, Value)
			End Set
		End Property


	#End Region  
	
	#Region "String Properties" 

		Public Overridable Property s_Id As String
			Get
				If Me.IsColumnNull(ColumnNames.Id) Then
					Return String.Empty
				Else
					Return MyBase.GetIntegerAsString(ColumnNames.Id)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Id)
				Else
					Me.Id = MyBase.SetIntegerAsString(ColumnNames.Id, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Username As String
			Get
				If Me.IsColumnNull(ColumnNames.Username) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.Username)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Username)
				Else
					Me.Username = MyBase.SetStringAsString(ColumnNames.Username, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Password As String
			Get
				If Me.IsColumnNull(ColumnNames.Password) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.Password)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Password)
				Else
					Me.Password = MyBase.SetStringAsString(ColumnNames.Password, Value)
				End If
			End Set
		End Property


	#End Region  	

	#Region "Where Clause"
    Public Class WhereClause

        Public Sub New(ByVal entity As BusinessEntity)
            Me._entity = entity
        End Sub
		
		Public ReadOnly Property TearOff As TearOffWhereParameter
			Get
				If _tearOff Is Nothing Then
					_tearOff = new TearOffWhereParameter(Me)
				End If

				Return _tearOff
			End Get
		End Property

		#Region "TearOff's"
		Public class TearOffWhereParameter

			Public Sub New(ByVal clause As WhereClause)
				Me._clause = clause
			End Sub
		
	
			Public ReadOnly Property Id() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Id, Parameters.Id)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Username() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Username, Parameters.Username)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Password() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Password, Parameters.Password)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property


			Private _clause as WhereClause
		End Class
		#End Region	

		Public ReadOnly Property Id() As WhereParameter 
			Get
				If _Id_W Is Nothing Then
					_Id_W = TearOff.Id
				End If
				Return _Id_W
			End Get
		End Property

		Public ReadOnly Property Username() As WhereParameter 
			Get
				If _Username_W Is Nothing Then
					_Username_W = TearOff.Username
				End If
				Return _Username_W
			End Get
		End Property

		Public ReadOnly Property Password() As WhereParameter 
			Get
				If _Password_W Is Nothing Then
					_Password_W = TearOff.Password
				End If
				Return _Password_W
			End Get
		End Property

		Private _Id_W As WhereParameter = Nothing
		Private _Username_W As WhereParameter = Nothing
		Private _Password_W As WhereParameter = Nothing

			Public Sub WhereClauseReset()

			_Id_W = Nothing
			_Username_W = Nothing
			_Password_W = Nothing
				Me._entity.Query.FlushWhereParameters()

			End Sub
	
		Private _entity As BusinessEntity
		Private _tearOff As TearOffWhereParameter
    End Class	

	Public ReadOnly Property Where() As WhereClause
		Get
			If _whereClause Is Nothing Then
				_whereClause = New WhereClause(Me)
			End If
	
			Return _whereClause
		End Get
	End Property
	
	Private _whereClause As WhereClause = Nothing	
#End Region	

#Region "Aggregate Clause"
    Public Class AggregateClause

        Public Sub New(ByVal entity As BusinessEntity)
            Me._entity = entity
        End Sub
		
		Public ReadOnly Property TearOff As TearOffAggregateParameter
			Get
				If _tearOff Is Nothing Then
					_tearOff = new TearOffAggregateParameter(Me)
				End If

				Return _tearOff
			End Get
		End Property

		#Region "AggregateParameter TearOff's"
		Public class TearOffAggregateParameter

			Public Sub New(ByVal clause As AggregateClause)
				Me._clause = clause
			End Sub
		
	
		Public ReadOnly Property Id() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Id, Parameters.Id)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Username() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Username, Parameters.Username)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Password() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Password, Parameters.Password)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property


			Private _clause as AggregateClause
		End Class
		#End Region	

		Public ReadOnly Property Id() As AggregateParameter 
			Get
				If _Id_W Is Nothing Then
					_Id_W = TearOff.Id
				End If
				Return _Id_W
			End Get
		End Property

		Public ReadOnly Property Username() As AggregateParameter 
			Get
				If _Username_W Is Nothing Then
					_Username_W = TearOff.Username
				End If
				Return _Username_W
			End Get
		End Property

		Public ReadOnly Property Password() As AggregateParameter 
			Get
				If _Password_W Is Nothing Then
					_Password_W = TearOff.Password
				End If
				Return _Password_W
			End Get
		End Property

		Private _Id_W As AggregateParameter = Nothing
		Private _Username_W As AggregateParameter = Nothing
		Private _Password_W As AggregateParameter = Nothing

		Public Sub AggregateClauseReset()

		_Id_W = Nothing
		_Username_W = Nothing
		_Password_W = Nothing
			Me._entity.Query.FlushAggregateParameters()

		End Sub
	
		Private _entity As BusinessEntity
		Private _tearOff As TearOffAggregateParameter
    End Class	

	Public ReadOnly Property Aggregate() As AggregateClause
		Get
			If _aggregateClause Is Nothing Then
				_aggregateClause = New AggregateClause(Me)
			End If
	
			Return _aggregateClause
		End Get
	End Property
	
	Private _aggregateClause As AggregateClause = Nothing	
#End Region	

	Protected Overrides Function GetInsertCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_Tbluser_masterInsert]" 
	    
		CreateParameters(cmd)
		
		Dim p As SqlParameter
		p = cmd.Parameters(Parameters.Id.ParameterName)
		p.Direction = ParameterDirection.Output
    
		Return cmd 

  	End Function
	
	Protected Overrides Function GetUpdateCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_Tbluser_masterUpdate]" 
		
		CreateParameters(cmd) 
		    
		Return cmd
	
	End Function	
	
	Protected Overrides Function GetDeleteCommand() As IDbCommand
	
		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure    
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_Tbluser_masterDelete]" 
		
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.Id)
		p.SourceColumn = ColumnNames.Id
		p.SourceVersion = DataRowVersion.Current

  
		Return cmd
	
	End Function	
	
	Private Sub CreateParameters(ByVal cmd As SqlCommand)
	
		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.Id)
		p.SourceColumn = ColumnNames.Id
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Username)
		p.SourceColumn = ColumnNames.Username
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Password)
		p.SourceColumn = ColumnNames.Password
		p.SourceVersion = DataRowVersion.Current


	End Sub	

End Class
