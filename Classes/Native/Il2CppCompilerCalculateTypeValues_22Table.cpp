#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "il2cpp-class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"


// System.Char[]
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2;
// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable>
struct Dictionary_2_tC8E0B27D96320233525C7F0E36266BE030D852B2;
// System.Collections.Generic.List`1<System.Linq.Expressions.Interpreter.LocalVariables/VariableScope>
struct List_1_tF6196D02E8C8D3A49C8257B38C00DA167D8EBD29;
// System.Linq.Expressions.Interpreter.ByRefUpdater[]
struct ByRefUpdaterU5BU5D_tDB1EB5674027EBA8F3752913C79D156F07CF97F7;
// System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariables/VariableScope>
struct HybridReferenceDictionary_2_tFBF985433C04703F52F5D62E82CA4F3A43B1390E;
// System.Linq.Expressions.Interpreter.Instruction
struct Instruction_t235F1D5246CE88164576679572E0E858988436C3;
// System.Linq.Expressions.Interpreter.LocalVariable
struct LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752;
// System.Linq.Expressions.ParameterExpression
struct ParameterExpression_t616ADBE354C741C2F0ABA5856714FC0607DEC217;
// System.Reflection.ConstructorInfo
struct ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF;
// System.String
struct String_t;
// System.Type
struct Type_t;




#ifndef RUNTIMEOBJECT_H
#define RUNTIMEOBJECT_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEOBJECT_H
#ifndef INSTRUCTION_T235F1D5246CE88164576679572E0E858988436C3_H
#define INSTRUCTION_T235F1D5246CE88164576679572E0E858988436C3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.Instruction
struct  Instruction_t235F1D5246CE88164576679572E0E858988436C3  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INSTRUCTION_T235F1D5246CE88164576679572E0E858988436C3_H
#ifndef LOCALVARIABLE_T4876B01B79DC675A325C66D1B473DD480C5FB752_H
#define LOCALVARIABLE_T4876B01B79DC675A325C66D1B473DD480C5FB752_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LocalVariable
struct  LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Expressions.Interpreter.LocalVariable::Index
	int32_t ___Index_0;
	// System.Int32 System.Linq.Expressions.Interpreter.LocalVariable::_flags
	int32_t ____flags_1;

public:
	inline static int32_t get_offset_of_Index_0() { return static_cast<int32_t>(offsetof(LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752, ___Index_0)); }
	inline int32_t get_Index_0() const { return ___Index_0; }
	inline int32_t* get_address_of_Index_0() { return &___Index_0; }
	inline void set_Index_0(int32_t value)
	{
		___Index_0 = value;
	}

	inline static int32_t get_offset_of__flags_1() { return static_cast<int32_t>(offsetof(LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752, ____flags_1)); }
	inline int32_t get__flags_1() const { return ____flags_1; }
	inline int32_t* get_address_of__flags_1() { return &____flags_1; }
	inline void set__flags_1(int32_t value)
	{
		____flags_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LOCALVARIABLE_T4876B01B79DC675A325C66D1B473DD480C5FB752_H
#ifndef LOCALVARIABLES_T6AA7555A7C165901095619CB9684D735C348201E_H
#define LOCALVARIABLES_T6AA7555A7C165901095619CB9684D735C348201E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LocalVariables
struct  LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E  : public RuntimeObject
{
public:
	// System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariables_VariableScope> System.Linq.Expressions.Interpreter.LocalVariables::_variables
	HybridReferenceDictionary_2_tFBF985433C04703F52F5D62E82CA4F3A43B1390E * ____variables_0;
	// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> System.Linq.Expressions.Interpreter.LocalVariables::_closureVariables
	Dictionary_2_tC8E0B27D96320233525C7F0E36266BE030D852B2 * ____closureVariables_1;
	// System.Int32 System.Linq.Expressions.Interpreter.LocalVariables::_localCount
	int32_t ____localCount_2;
	// System.Int32 System.Linq.Expressions.Interpreter.LocalVariables::_maxLocalCount
	int32_t ____maxLocalCount_3;

public:
	inline static int32_t get_offset_of__variables_0() { return static_cast<int32_t>(offsetof(LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E, ____variables_0)); }
	inline HybridReferenceDictionary_2_tFBF985433C04703F52F5D62E82CA4F3A43B1390E * get__variables_0() const { return ____variables_0; }
	inline HybridReferenceDictionary_2_tFBF985433C04703F52F5D62E82CA4F3A43B1390E ** get_address_of__variables_0() { return &____variables_0; }
	inline void set__variables_0(HybridReferenceDictionary_2_tFBF985433C04703F52F5D62E82CA4F3A43B1390E * value)
	{
		____variables_0 = value;
		Il2CppCodeGenWriteBarrier((&____variables_0), value);
	}

	inline static int32_t get_offset_of__closureVariables_1() { return static_cast<int32_t>(offsetof(LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E, ____closureVariables_1)); }
	inline Dictionary_2_tC8E0B27D96320233525C7F0E36266BE030D852B2 * get__closureVariables_1() const { return ____closureVariables_1; }
	inline Dictionary_2_tC8E0B27D96320233525C7F0E36266BE030D852B2 ** get_address_of__closureVariables_1() { return &____closureVariables_1; }
	inline void set__closureVariables_1(Dictionary_2_tC8E0B27D96320233525C7F0E36266BE030D852B2 * value)
	{
		____closureVariables_1 = value;
		Il2CppCodeGenWriteBarrier((&____closureVariables_1), value);
	}

	inline static int32_t get_offset_of__localCount_2() { return static_cast<int32_t>(offsetof(LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E, ____localCount_2)); }
	inline int32_t get__localCount_2() const { return ____localCount_2; }
	inline int32_t* get_address_of__localCount_2() { return &____localCount_2; }
	inline void set__localCount_2(int32_t value)
	{
		____localCount_2 = value;
	}

	inline static int32_t get_offset_of__maxLocalCount_3() { return static_cast<int32_t>(offsetof(LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E, ____maxLocalCount_3)); }
	inline int32_t get__maxLocalCount_3() const { return ____maxLocalCount_3; }
	inline int32_t* get_address_of__maxLocalCount_3() { return &____maxLocalCount_3; }
	inline void set__maxLocalCount_3(int32_t value)
	{
		____maxLocalCount_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LOCALVARIABLES_T6AA7555A7C165901095619CB9684D735C348201E_H
#ifndef VARIABLESCOPE_TC8F26DB0A896598371ABF001A5842281D95F925E_H
#define VARIABLESCOPE_TC8F26DB0A896598371ABF001A5842281D95F925E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LocalVariables_VariableScope
struct  VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Expressions.Interpreter.LocalVariables_VariableScope::Start
	int32_t ___Start_0;
	// System.Int32 System.Linq.Expressions.Interpreter.LocalVariables_VariableScope::Stop
	int32_t ___Stop_1;
	// System.Linq.Expressions.Interpreter.LocalVariable System.Linq.Expressions.Interpreter.LocalVariables_VariableScope::Variable
	LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752 * ___Variable_2;
	// System.Linq.Expressions.Interpreter.LocalVariables_VariableScope System.Linq.Expressions.Interpreter.LocalVariables_VariableScope::Parent
	VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E * ___Parent_3;
	// System.Collections.Generic.List`1<System.Linq.Expressions.Interpreter.LocalVariables_VariableScope> System.Linq.Expressions.Interpreter.LocalVariables_VariableScope::ChildScopes
	List_1_tF6196D02E8C8D3A49C8257B38C00DA167D8EBD29 * ___ChildScopes_4;

public:
	inline static int32_t get_offset_of_Start_0() { return static_cast<int32_t>(offsetof(VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E, ___Start_0)); }
	inline int32_t get_Start_0() const { return ___Start_0; }
	inline int32_t* get_address_of_Start_0() { return &___Start_0; }
	inline void set_Start_0(int32_t value)
	{
		___Start_0 = value;
	}

	inline static int32_t get_offset_of_Stop_1() { return static_cast<int32_t>(offsetof(VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E, ___Stop_1)); }
	inline int32_t get_Stop_1() const { return ___Stop_1; }
	inline int32_t* get_address_of_Stop_1() { return &___Stop_1; }
	inline void set_Stop_1(int32_t value)
	{
		___Stop_1 = value;
	}

	inline static int32_t get_offset_of_Variable_2() { return static_cast<int32_t>(offsetof(VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E, ___Variable_2)); }
	inline LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752 * get_Variable_2() const { return ___Variable_2; }
	inline LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752 ** get_address_of_Variable_2() { return &___Variable_2; }
	inline void set_Variable_2(LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752 * value)
	{
		___Variable_2 = value;
		Il2CppCodeGenWriteBarrier((&___Variable_2), value);
	}

	inline static int32_t get_offset_of_Parent_3() { return static_cast<int32_t>(offsetof(VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E, ___Parent_3)); }
	inline VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E * get_Parent_3() const { return ___Parent_3; }
	inline VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E ** get_address_of_Parent_3() { return &___Parent_3; }
	inline void set_Parent_3(VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E * value)
	{
		___Parent_3 = value;
		Il2CppCodeGenWriteBarrier((&___Parent_3), value);
	}

	inline static int32_t get_offset_of_ChildScopes_4() { return static_cast<int32_t>(offsetof(VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E, ___ChildScopes_4)); }
	inline List_1_tF6196D02E8C8D3A49C8257B38C00DA167D8EBD29 * get_ChildScopes_4() const { return ___ChildScopes_4; }
	inline List_1_tF6196D02E8C8D3A49C8257B38C00DA167D8EBD29 ** get_address_of_ChildScopes_4() { return &___ChildScopes_4; }
	inline void set_ChildScopes_4(List_1_tF6196D02E8C8D3A49C8257B38C00DA167D8EBD29 * value)
	{
		___ChildScopes_4 = value;
		Il2CppCodeGenWriteBarrier((&___ChildScopes_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VARIABLESCOPE_TC8F26DB0A896598371ABF001A5842281D95F925E_H
#ifndef VALUETYPE_T4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_H
#define VALUETYPE_T4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct  ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_com
{
};
#endif // VALUETYPE_T4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_H
#ifndef ENUM_T2AF27C02B8653AE29442467390005ABC74D8F521_H
#define ENUM_T2AF27C02B8653AE29442467390005ABC74D8F521_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Enum
struct  Enum_t2AF27C02B8653AE29442467390005ABC74D8F521  : public ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF
{
public:

public:
};

struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((&___enumSeperatorCharArray_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_com
{
};
#endif // ENUM_T2AF27C02B8653AE29442467390005ABC74D8F521_H
#ifndef LOCALACCESSINSTRUCTION_TBF932FCE7F4E923971CCA0751050DB88B668A4E9_H
#define LOCALACCESSINSTRUCTION_TBF932FCE7F4E923971CCA0751050DB88B668A4E9_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LocalAccessInstruction
struct  LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Int32 System.Linq.Expressions.Interpreter.LocalAccessInstruction::_index
	int32_t ____index_0;

public:
	inline static int32_t get_offset_of__index_0() { return static_cast<int32_t>(offsetof(LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9, ____index_0)); }
	inline int32_t get__index_0() const { return ____index_0; }
	inline int32_t* get_address_of__index_0() { return &____index_0; }
	inline void set__index_0(int32_t value)
	{
		____index_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LOCALACCESSINSTRUCTION_TBF932FCE7F4E923971CCA0751050DB88B668A4E9_H
#ifndef LOCALDEFINITION_T6EB6DABA8D559626495A9D03AFEE82848A905C2D_H
#define LOCALDEFINITION_T6EB6DABA8D559626495A9D03AFEE82848A905C2D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LocalDefinition
struct  LocalDefinition_t6EB6DABA8D559626495A9D03AFEE82848A905C2D 
{
public:
	// System.Int32 System.Linq.Expressions.Interpreter.LocalDefinition::<Index>k__BackingField
	int32_t ___U3CIndexU3Ek__BackingField_0;
	// System.Linq.Expressions.ParameterExpression System.Linq.Expressions.Interpreter.LocalDefinition::<Parameter>k__BackingField
	ParameterExpression_t616ADBE354C741C2F0ABA5856714FC0607DEC217 * ___U3CParameterU3Ek__BackingField_1;

public:
	inline static int32_t get_offset_of_U3CIndexU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(LocalDefinition_t6EB6DABA8D559626495A9D03AFEE82848A905C2D, ___U3CIndexU3Ek__BackingField_0)); }
	inline int32_t get_U3CIndexU3Ek__BackingField_0() const { return ___U3CIndexU3Ek__BackingField_0; }
	inline int32_t* get_address_of_U3CIndexU3Ek__BackingField_0() { return &___U3CIndexU3Ek__BackingField_0; }
	inline void set_U3CIndexU3Ek__BackingField_0(int32_t value)
	{
		___U3CIndexU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_U3CParameterU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(LocalDefinition_t6EB6DABA8D559626495A9D03AFEE82848A905C2D, ___U3CParameterU3Ek__BackingField_1)); }
	inline ParameterExpression_t616ADBE354C741C2F0ABA5856714FC0607DEC217 * get_U3CParameterU3Ek__BackingField_1() const { return ___U3CParameterU3Ek__BackingField_1; }
	inline ParameterExpression_t616ADBE354C741C2F0ABA5856714FC0607DEC217 ** get_address_of_U3CParameterU3Ek__BackingField_1() { return &___U3CParameterU3Ek__BackingField_1; }
	inline void set_U3CParameterU3Ek__BackingField_1(ParameterExpression_t616ADBE354C741C2F0ABA5856714FC0607DEC217 * value)
	{
		___U3CParameterU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((&___U3CParameterU3Ek__BackingField_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Linq.Expressions.Interpreter.LocalDefinition
struct LocalDefinition_t6EB6DABA8D559626495A9D03AFEE82848A905C2D_marshaled_pinvoke
{
	int32_t ___U3CIndexU3Ek__BackingField_0;
	ParameterExpression_t616ADBE354C741C2F0ABA5856714FC0607DEC217 * ___U3CParameterU3Ek__BackingField_1;
};
// Native definition for COM marshalling of System.Linq.Expressions.Interpreter.LocalDefinition
struct LocalDefinition_t6EB6DABA8D559626495A9D03AFEE82848A905C2D_marshaled_com
{
	int32_t ___U3CIndexU3Ek__BackingField_0;
	ParameterExpression_t616ADBE354C741C2F0ABA5856714FC0607DEC217 * ___U3CParameterU3Ek__BackingField_1;
};
#endif // LOCALDEFINITION_T6EB6DABA8D559626495A9D03AFEE82848A905C2D_H
#ifndef MODULOINSTRUCTION_T914B2DFCC1E53A553279FDF9B63E39228E669983_H
#define MODULOINSTRUCTION_T914B2DFCC1E53A553279FDF9B63E39228E669983_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ModuloInstruction
struct  ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ModuloInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ModuloInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ModuloInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ModuloInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ModuloInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ModuloInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_5;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ModuloInstruction::s_Single
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Single_6;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ModuloInstruction::s_Double
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Double_7;

public:
	inline static int32_t get_offset_of_s_Int16_0() { return static_cast<int32_t>(offsetof(ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields, ___s_Int16_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_0() const { return ___s_Int16_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_0() { return &___s_Int16_0; }
	inline void set_s_Int16_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_0), value);
	}

	inline static int32_t get_offset_of_s_Int32_1() { return static_cast<int32_t>(offsetof(ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields, ___s_Int32_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_1() const { return ___s_Int32_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_1() { return &___s_Int32_1; }
	inline void set_s_Int32_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_1), value);
	}

	inline static int32_t get_offset_of_s_Int64_2() { return static_cast<int32_t>(offsetof(ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields, ___s_Int64_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_2() const { return ___s_Int64_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_2() { return &___s_Int64_2; }
	inline void set_s_Int64_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_2), value);
	}

	inline static int32_t get_offset_of_s_UInt16_3() { return static_cast<int32_t>(offsetof(ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields, ___s_UInt16_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_3() const { return ___s_UInt16_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_3() { return &___s_UInt16_3; }
	inline void set_s_UInt16_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_3), value);
	}

	inline static int32_t get_offset_of_s_UInt32_4() { return static_cast<int32_t>(offsetof(ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields, ___s_UInt32_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_4() const { return ___s_UInt32_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_4() { return &___s_UInt32_4; }
	inline void set_s_UInt32_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_4), value);
	}

	inline static int32_t get_offset_of_s_UInt64_5() { return static_cast<int32_t>(offsetof(ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields, ___s_UInt64_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_5() const { return ___s_UInt64_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_5() { return &___s_UInt64_5; }
	inline void set_s_UInt64_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_5), value);
	}

	inline static int32_t get_offset_of_s_Single_6() { return static_cast<int32_t>(offsetof(ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields, ___s_Single_6)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Single_6() const { return ___s_Single_6; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Single_6() { return &___s_Single_6; }
	inline void set_s_Single_6(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Single_6 = value;
		Il2CppCodeGenWriteBarrier((&___s_Single_6), value);
	}

	inline static int32_t get_offset_of_s_Double_7() { return static_cast<int32_t>(offsetof(ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields, ___s_Double_7)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Double_7() const { return ___s_Double_7; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Double_7() { return &___s_Double_7; }
	inline void set_s_Double_7(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Double_7 = value;
		Il2CppCodeGenWriteBarrier((&___s_Double_7), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MODULOINSTRUCTION_T914B2DFCC1E53A553279FDF9B63E39228E669983_H
#ifndef MULINSTRUCTION_TB50503026C7505F69BE66FA64659386DD51A40A3_H
#define MULINSTRUCTION_TB50503026C7505F69BE66FA64659386DD51A40A3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulInstruction
struct  MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_5;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulInstruction::s_Single
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Single_6;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulInstruction::s_Double
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Double_7;

public:
	inline static int32_t get_offset_of_s_Int16_0() { return static_cast<int32_t>(offsetof(MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields, ___s_Int16_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_0() const { return ___s_Int16_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_0() { return &___s_Int16_0; }
	inline void set_s_Int16_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_0), value);
	}

	inline static int32_t get_offset_of_s_Int32_1() { return static_cast<int32_t>(offsetof(MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields, ___s_Int32_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_1() const { return ___s_Int32_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_1() { return &___s_Int32_1; }
	inline void set_s_Int32_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_1), value);
	}

	inline static int32_t get_offset_of_s_Int64_2() { return static_cast<int32_t>(offsetof(MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields, ___s_Int64_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_2() const { return ___s_Int64_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_2() { return &___s_Int64_2; }
	inline void set_s_Int64_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_2), value);
	}

	inline static int32_t get_offset_of_s_UInt16_3() { return static_cast<int32_t>(offsetof(MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields, ___s_UInt16_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_3() const { return ___s_UInt16_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_3() { return &___s_UInt16_3; }
	inline void set_s_UInt16_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_3), value);
	}

	inline static int32_t get_offset_of_s_UInt32_4() { return static_cast<int32_t>(offsetof(MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields, ___s_UInt32_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_4() const { return ___s_UInt32_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_4() { return &___s_UInt32_4; }
	inline void set_s_UInt32_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_4), value);
	}

	inline static int32_t get_offset_of_s_UInt64_5() { return static_cast<int32_t>(offsetof(MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields, ___s_UInt64_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_5() const { return ___s_UInt64_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_5() { return &___s_UInt64_5; }
	inline void set_s_UInt64_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_5), value);
	}

	inline static int32_t get_offset_of_s_Single_6() { return static_cast<int32_t>(offsetof(MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields, ___s_Single_6)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Single_6() const { return ___s_Single_6; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Single_6() { return &___s_Single_6; }
	inline void set_s_Single_6(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Single_6 = value;
		Il2CppCodeGenWriteBarrier((&___s_Single_6), value);
	}

	inline static int32_t get_offset_of_s_Double_7() { return static_cast<int32_t>(offsetof(MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields, ___s_Double_7)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Double_7() const { return ___s_Double_7; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Double_7() { return &___s_Double_7; }
	inline void set_s_Double_7(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Double_7 = value;
		Il2CppCodeGenWriteBarrier((&___s_Double_7), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULINSTRUCTION_TB50503026C7505F69BE66FA64659386DD51A40A3_H
#ifndef MULOVFINSTRUCTION_T0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_H
#define MULOVFINSTRUCTION_T0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulOvfInstruction
struct  MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulOvfInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulOvfInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulOvfInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulOvfInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulOvfInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.MulOvfInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_5;

public:
	inline static int32_t get_offset_of_s_Int16_0() { return static_cast<int32_t>(offsetof(MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields, ___s_Int16_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_0() const { return ___s_Int16_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_0() { return &___s_Int16_0; }
	inline void set_s_Int16_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_0), value);
	}

	inline static int32_t get_offset_of_s_Int32_1() { return static_cast<int32_t>(offsetof(MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields, ___s_Int32_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_1() const { return ___s_Int32_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_1() { return &___s_Int32_1; }
	inline void set_s_Int32_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_1), value);
	}

	inline static int32_t get_offset_of_s_Int64_2() { return static_cast<int32_t>(offsetof(MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields, ___s_Int64_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_2() const { return ___s_Int64_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_2() { return &___s_Int64_2; }
	inline void set_s_Int64_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_2), value);
	}

	inline static int32_t get_offset_of_s_UInt16_3() { return static_cast<int32_t>(offsetof(MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields, ___s_UInt16_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_3() const { return ___s_UInt16_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_3() { return &___s_UInt16_3; }
	inline void set_s_UInt16_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_3), value);
	}

	inline static int32_t get_offset_of_s_UInt32_4() { return static_cast<int32_t>(offsetof(MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields, ___s_UInt32_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_4() const { return ___s_UInt32_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_4() { return &___s_UInt32_4; }
	inline void set_s_UInt32_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_4), value);
	}

	inline static int32_t get_offset_of_s_UInt64_5() { return static_cast<int32_t>(offsetof(MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields, ___s_UInt64_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_5() const { return ___s_UInt64_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_5() { return &___s_UInt64_5; }
	inline void set_s_UInt64_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULOVFINSTRUCTION_T0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_H
#ifndef NEGATECHECKEDINSTRUCTION_TF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_H
#define NEGATECHECKEDINSTRUCTION_TF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateCheckedInstruction
struct  NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NegateCheckedInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NegateCheckedInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NegateCheckedInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_2;

public:
	inline static int32_t get_offset_of_s_Int16_0() { return static_cast<int32_t>(offsetof(NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_StaticFields, ___s_Int16_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_0() const { return ___s_Int16_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_0() { return &___s_Int16_0; }
	inline void set_s_Int16_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_0), value);
	}

	inline static int32_t get_offset_of_s_Int32_1() { return static_cast<int32_t>(offsetof(NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_StaticFields, ___s_Int32_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_1() const { return ___s_Int32_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_1() { return &___s_Int32_1; }
	inline void set_s_Int32_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_1), value);
	}

	inline static int32_t get_offset_of_s_Int64_2() { return static_cast<int32_t>(offsetof(NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_StaticFields, ___s_Int64_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_2() const { return ___s_Int64_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_2() { return &___s_Int64_2; }
	inline void set_s_Int64_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATECHECKEDINSTRUCTION_TF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_H
#ifndef NEGATEINSTRUCTION_T31A1B4199FB9B7A64604441569CC6247CEEF19E1_H
#define NEGATEINSTRUCTION_T31A1B4199FB9B7A64604441569CC6247CEEF19E1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateInstruction
struct  NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NegateInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NegateInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NegateInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NegateInstruction::s_Single
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Single_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NegateInstruction::s_Double
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Double_4;

public:
	inline static int32_t get_offset_of_s_Int16_0() { return static_cast<int32_t>(offsetof(NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields, ___s_Int16_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_0() const { return ___s_Int16_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_0() { return &___s_Int16_0; }
	inline void set_s_Int16_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_0), value);
	}

	inline static int32_t get_offset_of_s_Int32_1() { return static_cast<int32_t>(offsetof(NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields, ___s_Int32_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_1() const { return ___s_Int32_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_1() { return &___s_Int32_1; }
	inline void set_s_Int32_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_1), value);
	}

	inline static int32_t get_offset_of_s_Int64_2() { return static_cast<int32_t>(offsetof(NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields, ___s_Int64_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_2() const { return ___s_Int64_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_2() { return &___s_Int64_2; }
	inline void set_s_Int64_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_2), value);
	}

	inline static int32_t get_offset_of_s_Single_3() { return static_cast<int32_t>(offsetof(NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields, ___s_Single_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Single_3() const { return ___s_Single_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Single_3() { return &___s_Single_3; }
	inline void set_s_Single_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Single_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_Single_3), value);
	}

	inline static int32_t get_offset_of_s_Double_4() { return static_cast<int32_t>(offsetof(NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields, ___s_Double_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Double_4() const { return ___s_Double_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Double_4() { return &___s_Double_4; }
	inline void set_s_Double_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Double_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_Double_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATEINSTRUCTION_T31A1B4199FB9B7A64604441569CC6247CEEF19E1_H
#ifndef NEWINSTRUCTION_T3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E_H
#define NEWINSTRUCTION_T3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NewInstruction
struct  NewInstruction_t3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Reflection.ConstructorInfo System.Linq.Expressions.Interpreter.NewInstruction::_constructor
	ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF * ____constructor_0;
	// System.Int32 System.Linq.Expressions.Interpreter.NewInstruction::_argumentCount
	int32_t ____argumentCount_1;

public:
	inline static int32_t get_offset_of__constructor_0() { return static_cast<int32_t>(offsetof(NewInstruction_t3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E, ____constructor_0)); }
	inline ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF * get__constructor_0() const { return ____constructor_0; }
	inline ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF ** get_address_of__constructor_0() { return &____constructor_0; }
	inline void set__constructor_0(ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF * value)
	{
		____constructor_0 = value;
		Il2CppCodeGenWriteBarrier((&____constructor_0), value);
	}

	inline static int32_t get_offset_of__argumentCount_1() { return static_cast<int32_t>(offsetof(NewInstruction_t3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E, ____argumentCount_1)); }
	inline int32_t get__argumentCount_1() const { return ____argumentCount_1; }
	inline int32_t* get_address_of__argumentCount_1() { return &____argumentCount_1; }
	inline void set__argumentCount_1(int32_t value)
	{
		____argumentCount_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEWINSTRUCTION_T3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E_H
#ifndef NOTEQUALINSTRUCTION_TFD850A1858371685EE6F07767D4EBF7DAACE24F3_H
#define NOTEQUALINSTRUCTION_TFD850A1858371685EE6F07767D4EBF7DAACE24F3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction
struct  NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_reference
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_reference_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Boolean
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Boolean_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_SByte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_SByte_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Char
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Char_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_5;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_6;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Byte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Byte_7;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_8;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_9;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_10;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Single
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Single_11;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Double
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Double_12;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_SByteLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_SByteLiftedToNull_13;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Int16LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16LiftedToNull_14;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_CharLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_CharLiftedToNull_15;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Int32LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32LiftedToNull_16;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_Int64LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64LiftedToNull_17;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_ByteLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_ByteLiftedToNull_18;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_UInt16LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16LiftedToNull_19;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_UInt32LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32LiftedToNull_20;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_UInt64LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64LiftedToNull_21;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_SingleLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_SingleLiftedToNull_22;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotEqualInstruction::s_DoubleLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_DoubleLiftedToNull_23;

public:
	inline static int32_t get_offset_of_s_reference_0() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_reference_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_reference_0() const { return ___s_reference_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_reference_0() { return &___s_reference_0; }
	inline void set_s_reference_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_reference_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_reference_0), value);
	}

	inline static int32_t get_offset_of_s_Boolean_1() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Boolean_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Boolean_1() const { return ___s_Boolean_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Boolean_1() { return &___s_Boolean_1; }
	inline void set_s_Boolean_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Boolean_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Boolean_1), value);
	}

	inline static int32_t get_offset_of_s_SByte_2() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_SByte_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_SByte_2() const { return ___s_SByte_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_SByte_2() { return &___s_SByte_2; }
	inline void set_s_SByte_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_SByte_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_SByte_2), value);
	}

	inline static int32_t get_offset_of_s_Int16_3() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Int16_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_3() const { return ___s_Int16_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_3() { return &___s_Int16_3; }
	inline void set_s_Int16_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_3), value);
	}

	inline static int32_t get_offset_of_s_Char_4() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Char_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Char_4() const { return ___s_Char_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Char_4() { return &___s_Char_4; }
	inline void set_s_Char_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Char_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_Char_4), value);
	}

	inline static int32_t get_offset_of_s_Int32_5() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Int32_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_5() const { return ___s_Int32_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_5() { return &___s_Int32_5; }
	inline void set_s_Int32_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_5), value);
	}

	inline static int32_t get_offset_of_s_Int64_6() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Int64_6)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_6() const { return ___s_Int64_6; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_6() { return &___s_Int64_6; }
	inline void set_s_Int64_6(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_6 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_6), value);
	}

	inline static int32_t get_offset_of_s_Byte_7() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Byte_7)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Byte_7() const { return ___s_Byte_7; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Byte_7() { return &___s_Byte_7; }
	inline void set_s_Byte_7(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Byte_7 = value;
		Il2CppCodeGenWriteBarrier((&___s_Byte_7), value);
	}

	inline static int32_t get_offset_of_s_UInt16_8() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_UInt16_8)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_8() const { return ___s_UInt16_8; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_8() { return &___s_UInt16_8; }
	inline void set_s_UInt16_8(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_8 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_8), value);
	}

	inline static int32_t get_offset_of_s_UInt32_9() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_UInt32_9)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_9() const { return ___s_UInt32_9; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_9() { return &___s_UInt32_9; }
	inline void set_s_UInt32_9(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_9 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_9), value);
	}

	inline static int32_t get_offset_of_s_UInt64_10() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_UInt64_10)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_10() const { return ___s_UInt64_10; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_10() { return &___s_UInt64_10; }
	inline void set_s_UInt64_10(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_10 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_10), value);
	}

	inline static int32_t get_offset_of_s_Single_11() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Single_11)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Single_11() const { return ___s_Single_11; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Single_11() { return &___s_Single_11; }
	inline void set_s_Single_11(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Single_11 = value;
		Il2CppCodeGenWriteBarrier((&___s_Single_11), value);
	}

	inline static int32_t get_offset_of_s_Double_12() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Double_12)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Double_12() const { return ___s_Double_12; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Double_12() { return &___s_Double_12; }
	inline void set_s_Double_12(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Double_12 = value;
		Il2CppCodeGenWriteBarrier((&___s_Double_12), value);
	}

	inline static int32_t get_offset_of_s_SByteLiftedToNull_13() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_SByteLiftedToNull_13)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_SByteLiftedToNull_13() const { return ___s_SByteLiftedToNull_13; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_SByteLiftedToNull_13() { return &___s_SByteLiftedToNull_13; }
	inline void set_s_SByteLiftedToNull_13(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_SByteLiftedToNull_13 = value;
		Il2CppCodeGenWriteBarrier((&___s_SByteLiftedToNull_13), value);
	}

	inline static int32_t get_offset_of_s_Int16LiftedToNull_14() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Int16LiftedToNull_14)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16LiftedToNull_14() const { return ___s_Int16LiftedToNull_14; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16LiftedToNull_14() { return &___s_Int16LiftedToNull_14; }
	inline void set_s_Int16LiftedToNull_14(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16LiftedToNull_14 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16LiftedToNull_14), value);
	}

	inline static int32_t get_offset_of_s_CharLiftedToNull_15() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_CharLiftedToNull_15)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_CharLiftedToNull_15() const { return ___s_CharLiftedToNull_15; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_CharLiftedToNull_15() { return &___s_CharLiftedToNull_15; }
	inline void set_s_CharLiftedToNull_15(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_CharLiftedToNull_15 = value;
		Il2CppCodeGenWriteBarrier((&___s_CharLiftedToNull_15), value);
	}

	inline static int32_t get_offset_of_s_Int32LiftedToNull_16() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Int32LiftedToNull_16)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32LiftedToNull_16() const { return ___s_Int32LiftedToNull_16; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32LiftedToNull_16() { return &___s_Int32LiftedToNull_16; }
	inline void set_s_Int32LiftedToNull_16(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32LiftedToNull_16 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32LiftedToNull_16), value);
	}

	inline static int32_t get_offset_of_s_Int64LiftedToNull_17() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_Int64LiftedToNull_17)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64LiftedToNull_17() const { return ___s_Int64LiftedToNull_17; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64LiftedToNull_17() { return &___s_Int64LiftedToNull_17; }
	inline void set_s_Int64LiftedToNull_17(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64LiftedToNull_17 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64LiftedToNull_17), value);
	}

	inline static int32_t get_offset_of_s_ByteLiftedToNull_18() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_ByteLiftedToNull_18)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_ByteLiftedToNull_18() const { return ___s_ByteLiftedToNull_18; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_ByteLiftedToNull_18() { return &___s_ByteLiftedToNull_18; }
	inline void set_s_ByteLiftedToNull_18(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_ByteLiftedToNull_18 = value;
		Il2CppCodeGenWriteBarrier((&___s_ByteLiftedToNull_18), value);
	}

	inline static int32_t get_offset_of_s_UInt16LiftedToNull_19() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_UInt16LiftedToNull_19)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16LiftedToNull_19() const { return ___s_UInt16LiftedToNull_19; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16LiftedToNull_19() { return &___s_UInt16LiftedToNull_19; }
	inline void set_s_UInt16LiftedToNull_19(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16LiftedToNull_19 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16LiftedToNull_19), value);
	}

	inline static int32_t get_offset_of_s_UInt32LiftedToNull_20() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_UInt32LiftedToNull_20)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32LiftedToNull_20() const { return ___s_UInt32LiftedToNull_20; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32LiftedToNull_20() { return &___s_UInt32LiftedToNull_20; }
	inline void set_s_UInt32LiftedToNull_20(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32LiftedToNull_20 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32LiftedToNull_20), value);
	}

	inline static int32_t get_offset_of_s_UInt64LiftedToNull_21() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_UInt64LiftedToNull_21)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64LiftedToNull_21() const { return ___s_UInt64LiftedToNull_21; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64LiftedToNull_21() { return &___s_UInt64LiftedToNull_21; }
	inline void set_s_UInt64LiftedToNull_21(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64LiftedToNull_21 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64LiftedToNull_21), value);
	}

	inline static int32_t get_offset_of_s_SingleLiftedToNull_22() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_SingleLiftedToNull_22)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_SingleLiftedToNull_22() const { return ___s_SingleLiftedToNull_22; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_SingleLiftedToNull_22() { return &___s_SingleLiftedToNull_22; }
	inline void set_s_SingleLiftedToNull_22(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_SingleLiftedToNull_22 = value;
		Il2CppCodeGenWriteBarrier((&___s_SingleLiftedToNull_22), value);
	}

	inline static int32_t get_offset_of_s_DoubleLiftedToNull_23() { return static_cast<int32_t>(offsetof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields, ___s_DoubleLiftedToNull_23)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_DoubleLiftedToNull_23() const { return ___s_DoubleLiftedToNull_23; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_DoubleLiftedToNull_23() { return &___s_DoubleLiftedToNull_23; }
	inline void set_s_DoubleLiftedToNull_23(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_DoubleLiftedToNull_23 = value;
		Il2CppCodeGenWriteBarrier((&___s_DoubleLiftedToNull_23), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALINSTRUCTION_TFD850A1858371685EE6F07767D4EBF7DAACE24F3_H
#ifndef NOTINSTRUCTION_T4D8FFB3F6775BD663A1B8BDF961E616B665F4394_H
#define NOTINSTRUCTION_T4D8FFB3F6775BD663A1B8BDF961E616B665F4394_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction
struct  NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotInstruction::s_Boolean
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Boolean_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_5;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_6;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotInstruction::s_Byte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Byte_7;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NotInstruction::s_SByte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_SByte_8;

public:
	inline static int32_t get_offset_of_s_Boolean_0() { return static_cast<int32_t>(offsetof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields, ___s_Boolean_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Boolean_0() const { return ___s_Boolean_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Boolean_0() { return &___s_Boolean_0; }
	inline void set_s_Boolean_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Boolean_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_Boolean_0), value);
	}

	inline static int32_t get_offset_of_s_Int64_1() { return static_cast<int32_t>(offsetof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields, ___s_Int64_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_1() const { return ___s_Int64_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_1() { return &___s_Int64_1; }
	inline void set_s_Int64_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_1), value);
	}

	inline static int32_t get_offset_of_s_Int32_2() { return static_cast<int32_t>(offsetof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields, ___s_Int32_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_2() const { return ___s_Int32_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_2() { return &___s_Int32_2; }
	inline void set_s_Int32_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_2), value);
	}

	inline static int32_t get_offset_of_s_Int16_3() { return static_cast<int32_t>(offsetof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields, ___s_Int16_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_3() const { return ___s_Int16_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_3() { return &___s_Int16_3; }
	inline void set_s_Int16_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_3), value);
	}

	inline static int32_t get_offset_of_s_UInt64_4() { return static_cast<int32_t>(offsetof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields, ___s_UInt64_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_4() const { return ___s_UInt64_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_4() { return &___s_UInt64_4; }
	inline void set_s_UInt64_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_4), value);
	}

	inline static int32_t get_offset_of_s_UInt32_5() { return static_cast<int32_t>(offsetof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields, ___s_UInt32_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_5() const { return ___s_UInt32_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_5() { return &___s_UInt32_5; }
	inline void set_s_UInt32_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_5), value);
	}

	inline static int32_t get_offset_of_s_UInt16_6() { return static_cast<int32_t>(offsetof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields, ___s_UInt16_6)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_6() const { return ___s_UInt16_6; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_6() { return &___s_UInt16_6; }
	inline void set_s_UInt16_6(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_6 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_6), value);
	}

	inline static int32_t get_offset_of_s_Byte_7() { return static_cast<int32_t>(offsetof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields, ___s_Byte_7)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Byte_7() const { return ___s_Byte_7; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Byte_7() { return &___s_Byte_7; }
	inline void set_s_Byte_7(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Byte_7 = value;
		Il2CppCodeGenWriteBarrier((&___s_Byte_7), value);
	}

	inline static int32_t get_offset_of_s_SByte_8() { return static_cast<int32_t>(offsetof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields, ___s_SByte_8)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_SByte_8() const { return ___s_SByte_8; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_SByte_8() { return &___s_SByte_8; }
	inline void set_s_SByte_8(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_SByte_8 = value;
		Il2CppCodeGenWriteBarrier((&___s_SByte_8), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTINSTRUCTION_T4D8FFB3F6775BD663A1B8BDF961E616B665F4394_H
#ifndef NULLCHECKINSTRUCTION_TE91E4297947DDC4D25DB22D27BB64BB912940D80_H
#define NULLCHECKINSTRUCTION_TE91E4297947DDC4D25DB22D27BB64BB912940D80_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NullCheckInstruction
struct  NullCheckInstruction_tE91E4297947DDC4D25DB22D27BB64BB912940D80  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct NullCheckInstruction_tE91E4297947DDC4D25DB22D27BB64BB912940D80_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.NullCheckInstruction::Instance
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(NullCheckInstruction_tE91E4297947DDC4D25DB22D27BB64BB912940D80_StaticFields, ___Instance_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_Instance_0() const { return ___Instance_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_Instance_0() { return &___Instance_0; }
	inline void set_Instance_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___Instance_0 = value;
		Il2CppCodeGenWriteBarrier((&___Instance_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NULLCHECKINSTRUCTION_TE91E4297947DDC4D25DB22D27BB64BB912940D80_H
#ifndef RUNTIMEVARIABLESINSTRUCTION_T35C1BC0FF252C67827DA8018F16B089F7140D65A_H
#define RUNTIMEVARIABLESINSTRUCTION_T35C1BC0FF252C67827DA8018F16B089F7140D65A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.RuntimeVariablesInstruction
struct  RuntimeVariablesInstruction_t35C1BC0FF252C67827DA8018F16B089F7140D65A  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Int32 System.Linq.Expressions.Interpreter.RuntimeVariablesInstruction::_count
	int32_t ____count_0;

public:
	inline static int32_t get_offset_of__count_0() { return static_cast<int32_t>(offsetof(RuntimeVariablesInstruction_t35C1BC0FF252C67827DA8018F16B089F7140D65A, ____count_0)); }
	inline int32_t get__count_0() const { return ____count_0; }
	inline int32_t* get_address_of__count_0() { return &____count_0; }
	inline void set__count_0(int32_t value)
	{
		____count_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEVARIABLESINSTRUCTION_T35C1BC0FF252C67827DA8018F16B089F7140D65A_H
#ifndef VALUETYPECOPYINSTRUCTION_T23E216D257169A6157250599F73FE44C2E1F3F8A_H
#define VALUETYPECOPYINSTRUCTION_T23E216D257169A6157250599F73FE44C2E1F3F8A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ValueTypeCopyInstruction
struct  ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.ValueTypeCopyInstruction System.Linq.Expressions.Interpreter.ValueTypeCopyInstruction::Instruction
	ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A * ___Instruction_0;

public:
	inline static int32_t get_offset_of_Instruction_0() { return static_cast<int32_t>(offsetof(ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A_StaticFields, ___Instruction_0)); }
	inline ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A * get_Instruction_0() const { return ___Instruction_0; }
	inline ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A ** get_address_of_Instruction_0() { return &___Instruction_0; }
	inline void set_Instruction_0(ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A * value)
	{
		___Instruction_0 = value;
		Il2CppCodeGenWriteBarrier((&___Instruction_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VALUETYPECOPYINSTRUCTION_T23E216D257169A6157250599F73FE44C2E1F3F8A_H
#ifndef ASSIGNLOCALBOXEDINSTRUCTION_T5B8CA20241F46D5CB13CB66884EA1842DB0A2709_H
#define ASSIGNLOCALBOXEDINSTRUCTION_T5B8CA20241F46D5CB13CB66884EA1842DB0A2709_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AssignLocalBoxedInstruction
struct  AssignLocalBoxedInstruction_t5B8CA20241F46D5CB13CB66884EA1842DB0A2709  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ASSIGNLOCALBOXEDINSTRUCTION_T5B8CA20241F46D5CB13CB66884EA1842DB0A2709_H
#ifndef ASSIGNLOCALINSTRUCTION_TDD7CBDF01A0522841D8A61738C87D6A8118FE05F_H
#define ASSIGNLOCALINSTRUCTION_TDD7CBDF01A0522841D8A61738C87D6A8118FE05F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AssignLocalInstruction
struct  AssignLocalInstruction_tDD7CBDF01A0522841D8A61738C87D6A8118FE05F  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ASSIGNLOCALINSTRUCTION_TDD7CBDF01A0522841D8A61738C87D6A8118FE05F_H
#ifndef ASSIGNLOCALTOCLOSUREINSTRUCTION_TEF834FAA17D2143AF81A991440502FFEA26206AA_H
#define ASSIGNLOCALTOCLOSUREINSTRUCTION_TEF834FAA17D2143AF81A991440502FFEA26206AA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AssignLocalToClosureInstruction
struct  AssignLocalToClosureInstruction_tEF834FAA17D2143AF81A991440502FFEA26206AA  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ASSIGNLOCALTOCLOSUREINSTRUCTION_TEF834FAA17D2143AF81A991440502FFEA26206AA_H
#ifndef BYREFNEWINSTRUCTION_TF7C1A4D0859C569E7E4F00DA196EC318DA655477_H
#define BYREFNEWINSTRUCTION_TF7C1A4D0859C569E7E4F00DA196EC318DA655477_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ByRefNewInstruction
struct  ByRefNewInstruction_tF7C1A4D0859C569E7E4F00DA196EC318DA655477  : public NewInstruction_t3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E
{
public:
	// System.Linq.Expressions.Interpreter.ByRefUpdater[] System.Linq.Expressions.Interpreter.ByRefNewInstruction::_byrefArgs
	ByRefUpdaterU5BU5D_tDB1EB5674027EBA8F3752913C79D156F07CF97F7* ____byrefArgs_2;

public:
	inline static int32_t get_offset_of__byrefArgs_2() { return static_cast<int32_t>(offsetof(ByRefNewInstruction_tF7C1A4D0859C569E7E4F00DA196EC318DA655477, ____byrefArgs_2)); }
	inline ByRefUpdaterU5BU5D_tDB1EB5674027EBA8F3752913C79D156F07CF97F7* get__byrefArgs_2() const { return ____byrefArgs_2; }
	inline ByRefUpdaterU5BU5D_tDB1EB5674027EBA8F3752913C79D156F07CF97F7** get_address_of__byrefArgs_2() { return &____byrefArgs_2; }
	inline void set__byrefArgs_2(ByRefUpdaterU5BU5D_tDB1EB5674027EBA8F3752913C79D156F07CF97F7* value)
	{
		____byrefArgs_2 = value;
		Il2CppCodeGenWriteBarrier((&____byrefArgs_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BYREFNEWINSTRUCTION_TF7C1A4D0859C569E7E4F00DA196EC318DA655477_H
#ifndef INITIALIZELOCALINSTRUCTION_TA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0_H
#define INITIALIZELOCALINSTRUCTION_TA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.InitializeLocalInstruction
struct  InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INITIALIZELOCALINSTRUCTION_TA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0_H
#ifndef LOADLOCALBOXEDINSTRUCTION_T8D4E88459DEA7475CAD9F4C8FD001B862CFFB40A_H
#define LOADLOCALBOXEDINSTRUCTION_T8D4E88459DEA7475CAD9F4C8FD001B862CFFB40A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LoadLocalBoxedInstruction
struct  LoadLocalBoxedInstruction_t8D4E88459DEA7475CAD9F4C8FD001B862CFFB40A  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LOADLOCALBOXEDINSTRUCTION_T8D4E88459DEA7475CAD9F4C8FD001B862CFFB40A_H
#ifndef LOADLOCALFROMCLOSUREBOXEDINSTRUCTION_TB50E923BC630A74B41389D002E0FCB56FE55E41F_H
#define LOADLOCALFROMCLOSUREBOXEDINSTRUCTION_TB50E923BC630A74B41389D002E0FCB56FE55E41F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LoadLocalFromClosureBoxedInstruction
struct  LoadLocalFromClosureBoxedInstruction_tB50E923BC630A74B41389D002E0FCB56FE55E41F  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LOADLOCALFROMCLOSUREBOXEDINSTRUCTION_TB50E923BC630A74B41389D002E0FCB56FE55E41F_H
#ifndef LOADLOCALFROMCLOSUREINSTRUCTION_T7A80323CE72C7E44154797B5979695CA52374BEA_H
#define LOADLOCALFROMCLOSUREINSTRUCTION_T7A80323CE72C7E44154797B5979695CA52374BEA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LoadLocalFromClosureInstruction
struct  LoadLocalFromClosureInstruction_t7A80323CE72C7E44154797B5979695CA52374BEA  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LOADLOCALFROMCLOSUREINSTRUCTION_T7A80323CE72C7E44154797B5979695CA52374BEA_H
#ifndef LOADLOCALINSTRUCTION_TDDC1A571CE7B66E853CFD81344A68291B3053AE5_H
#define LOADLOCALINSTRUCTION_TDDC1A571CE7B66E853CFD81344A68291B3053AE5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LoadLocalInstruction
struct  LoadLocalInstruction_tDDC1A571CE7B66E853CFD81344A68291B3053AE5  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LOADLOCALINSTRUCTION_TDDC1A571CE7B66E853CFD81344A68291B3053AE5_H
#ifndef MODULODOUBLE_T1509ED265C338A7AE04D6562ABB2CCF1B4B775D0_H
#define MODULODOUBLE_T1509ED265C338A7AE04D6562ABB2CCF1B4B775D0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ModuloInstruction_ModuloDouble
struct  ModuloDouble_t1509ED265C338A7AE04D6562ABB2CCF1B4B775D0  : public ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MODULODOUBLE_T1509ED265C338A7AE04D6562ABB2CCF1B4B775D0_H
#ifndef MODULOINT16_TAFE469D9CAD954A27438F7E3CA75C2726CADF96A_H
#define MODULOINT16_TAFE469D9CAD954A27438F7E3CA75C2726CADF96A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ModuloInstruction_ModuloInt16
struct  ModuloInt16_tAFE469D9CAD954A27438F7E3CA75C2726CADF96A  : public ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MODULOINT16_TAFE469D9CAD954A27438F7E3CA75C2726CADF96A_H
#ifndef MODULOINT32_TCCF0F7428C09D9907618F688AA9505721BA135DF_H
#define MODULOINT32_TCCF0F7428C09D9907618F688AA9505721BA135DF_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ModuloInstruction_ModuloInt32
struct  ModuloInt32_tCCF0F7428C09D9907618F688AA9505721BA135DF  : public ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MODULOINT32_TCCF0F7428C09D9907618F688AA9505721BA135DF_H
#ifndef MODULOINT64_T3115FC5838345A011DCE569F0B9B9252A5C246F1_H
#define MODULOINT64_T3115FC5838345A011DCE569F0B9B9252A5C246F1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ModuloInstruction_ModuloInt64
struct  ModuloInt64_t3115FC5838345A011DCE569F0B9B9252A5C246F1  : public ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MODULOINT64_T3115FC5838345A011DCE569F0B9B9252A5C246F1_H
#ifndef MODULOSINGLE_T3F0BE8201876C08493F66D99B5D4293807037A51_H
#define MODULOSINGLE_T3F0BE8201876C08493F66D99B5D4293807037A51_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ModuloInstruction_ModuloSingle
struct  ModuloSingle_t3F0BE8201876C08493F66D99B5D4293807037A51  : public ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MODULOSINGLE_T3F0BE8201876C08493F66D99B5D4293807037A51_H
#ifndef MODULOUINT16_T8AFCF86880F449F62399531FBB760D34B0A3BC06_H
#define MODULOUINT16_T8AFCF86880F449F62399531FBB760D34B0A3BC06_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ModuloInstruction_ModuloUInt16
struct  ModuloUInt16_t8AFCF86880F449F62399531FBB760D34B0A3BC06  : public ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MODULOUINT16_T8AFCF86880F449F62399531FBB760D34B0A3BC06_H
#ifndef MODULOUINT32_TBA94D2CD224FBF3CAD5ACAACA936E73E31A8967D_H
#define MODULOUINT32_TBA94D2CD224FBF3CAD5ACAACA936E73E31A8967D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ModuloInstruction_ModuloUInt32
struct  ModuloUInt32_tBA94D2CD224FBF3CAD5ACAACA936E73E31A8967D  : public ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MODULOUINT32_TBA94D2CD224FBF3CAD5ACAACA936E73E31A8967D_H
#ifndef MODULOUINT64_TE6C7B141AAA28C593C870B94D8B929C93A73A8FB_H
#define MODULOUINT64_TE6C7B141AAA28C593C870B94D8B929C93A73A8FB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ModuloInstruction_ModuloUInt64
struct  ModuloUInt64_tE6C7B141AAA28C593C870B94D8B929C93A73A8FB  : public ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MODULOUINT64_TE6C7B141AAA28C593C870B94D8B929C93A73A8FB_H
#ifndef MULDOUBLE_T376B753EC98DAB83F7ABC4C9870D5E46810EEF49_H
#define MULDOUBLE_T376B753EC98DAB83F7ABC4C9870D5E46810EEF49_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulInstruction_MulDouble
struct  MulDouble_t376B753EC98DAB83F7ABC4C9870D5E46810EEF49  : public MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULDOUBLE_T376B753EC98DAB83F7ABC4C9870D5E46810EEF49_H
#ifndef MULINT16_T735B0FD60D31F17800B1B9644F873CBD4EB97EC3_H
#define MULINT16_T735B0FD60D31F17800B1B9644F873CBD4EB97EC3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulInstruction_MulInt16
struct  MulInt16_t735B0FD60D31F17800B1B9644F873CBD4EB97EC3  : public MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULINT16_T735B0FD60D31F17800B1B9644F873CBD4EB97EC3_H
#ifndef MULINT32_T8E3552E45AFAA0231E8E6680C045A99DD7EEC75F_H
#define MULINT32_T8E3552E45AFAA0231E8E6680C045A99DD7EEC75F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulInstruction_MulInt32
struct  MulInt32_t8E3552E45AFAA0231E8E6680C045A99DD7EEC75F  : public MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULINT32_T8E3552E45AFAA0231E8E6680C045A99DD7EEC75F_H
#ifndef MULINT64_T5EE8DEC75AD17248FE0E0BD36E45C7616368262F_H
#define MULINT64_T5EE8DEC75AD17248FE0E0BD36E45C7616368262F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulInstruction_MulInt64
struct  MulInt64_t5EE8DEC75AD17248FE0E0BD36E45C7616368262F  : public MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULINT64_T5EE8DEC75AD17248FE0E0BD36E45C7616368262F_H
#ifndef MULSINGLE_T3B8EE9EB50F5A852AFC482F13D81475228C197BE_H
#define MULSINGLE_T3B8EE9EB50F5A852AFC482F13D81475228C197BE_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulInstruction_MulSingle
struct  MulSingle_t3B8EE9EB50F5A852AFC482F13D81475228C197BE  : public MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULSINGLE_T3B8EE9EB50F5A852AFC482F13D81475228C197BE_H
#ifndef MULUINT16_T4872AE4C8C7899FD511902E4EAC06F47C7D76BE4_H
#define MULUINT16_T4872AE4C8C7899FD511902E4EAC06F47C7D76BE4_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulInstruction_MulUInt16
struct  MulUInt16_t4872AE4C8C7899FD511902E4EAC06F47C7D76BE4  : public MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULUINT16_T4872AE4C8C7899FD511902E4EAC06F47C7D76BE4_H
#ifndef MULUINT32_T02CB609A82516E9D984B55A233003AAFAD254D26_H
#define MULUINT32_T02CB609A82516E9D984B55A233003AAFAD254D26_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulInstruction_MulUInt32
struct  MulUInt32_t02CB609A82516E9D984B55A233003AAFAD254D26  : public MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULUINT32_T02CB609A82516E9D984B55A233003AAFAD254D26_H
#ifndef MULUINT64_T9551BBBF596994F0C598BFAA95600C57ECD845A1_H
#define MULUINT64_T9551BBBF596994F0C598BFAA95600C57ECD845A1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulInstruction_MulUInt64
struct  MulUInt64_t9551BBBF596994F0C598BFAA95600C57ECD845A1  : public MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULUINT64_T9551BBBF596994F0C598BFAA95600C57ECD845A1_H
#ifndef MULOVFINT16_TFA2495B40DEBFF451C7A390E07D4C92AD0160A95_H
#define MULOVFINT16_TFA2495B40DEBFF451C7A390E07D4C92AD0160A95_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulOvfInstruction_MulOvfInt16
struct  MulOvfInt16_tFA2495B40DEBFF451C7A390E07D4C92AD0160A95  : public MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULOVFINT16_TFA2495B40DEBFF451C7A390E07D4C92AD0160A95_H
#ifndef MULOVFINT32_TD27C55A50D8B4B9972EE9D1AD6DE132AFF522F95_H
#define MULOVFINT32_TD27C55A50D8B4B9972EE9D1AD6DE132AFF522F95_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulOvfInstruction_MulOvfInt32
struct  MulOvfInt32_tD27C55A50D8B4B9972EE9D1AD6DE132AFF522F95  : public MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULOVFINT32_TD27C55A50D8B4B9972EE9D1AD6DE132AFF522F95_H
#ifndef MULOVFINT64_T4CF3151A1DF49176246634F103318EA5C5FC039D_H
#define MULOVFINT64_T4CF3151A1DF49176246634F103318EA5C5FC039D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulOvfInstruction_MulOvfInt64
struct  MulOvfInt64_t4CF3151A1DF49176246634F103318EA5C5FC039D  : public MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULOVFINT64_T4CF3151A1DF49176246634F103318EA5C5FC039D_H
#ifndef MULOVFUINT16_T21FE81AFFA64286D3EF9E71BD049E23C838E6D80_H
#define MULOVFUINT16_T21FE81AFFA64286D3EF9E71BD049E23C838E6D80_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulOvfInstruction_MulOvfUInt16
struct  MulOvfUInt16_t21FE81AFFA64286D3EF9E71BD049E23C838E6D80  : public MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULOVFUINT16_T21FE81AFFA64286D3EF9E71BD049E23C838E6D80_H
#ifndef MULOVFUINT32_T582609E5C011F0FEDB7C6CD037A4FD48A35CA189_H
#define MULOVFUINT32_T582609E5C011F0FEDB7C6CD037A4FD48A35CA189_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulOvfInstruction_MulOvfUInt32
struct  MulOvfUInt32_t582609E5C011F0FEDB7C6CD037A4FD48A35CA189  : public MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULOVFUINT32_T582609E5C011F0FEDB7C6CD037A4FD48A35CA189_H
#ifndef MULOVFUINT64_T95B0CD36EBD8F30FB99F3C485DB49C82F07E8489_H
#define MULOVFUINT64_T95B0CD36EBD8F30FB99F3C485DB49C82F07E8489_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MulOvfInstruction_MulOvfUInt64
struct  MulOvfUInt64_t95B0CD36EBD8F30FB99F3C485DB49C82F07E8489  : public MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULOVFUINT64_T95B0CD36EBD8F30FB99F3C485DB49C82F07E8489_H
#ifndef NEGATECHECKEDINT16_T351B4E3F193182CE658C4F35EA78E179DE5458F1_H
#define NEGATECHECKEDINT16_T351B4E3F193182CE658C4F35EA78E179DE5458F1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateCheckedInstruction_NegateCheckedInt16
struct  NegateCheckedInt16_t351B4E3F193182CE658C4F35EA78E179DE5458F1  : public NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATECHECKEDINT16_T351B4E3F193182CE658C4F35EA78E179DE5458F1_H
#ifndef NEGATECHECKEDINT32_T67257D954DC2ADAEA9263975B278D2B878261B05_H
#define NEGATECHECKEDINT32_T67257D954DC2ADAEA9263975B278D2B878261B05_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateCheckedInstruction_NegateCheckedInt32
struct  NegateCheckedInt32_t67257D954DC2ADAEA9263975B278D2B878261B05  : public NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATECHECKEDINT32_T67257D954DC2ADAEA9263975B278D2B878261B05_H
#ifndef NEGATECHECKEDINT64_T62F4E4C0D7881039FF6A5D9FE788B0DF6096F751_H
#define NEGATECHECKEDINT64_T62F4E4C0D7881039FF6A5D9FE788B0DF6096F751_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateCheckedInstruction_NegateCheckedInt64
struct  NegateCheckedInt64_t62F4E4C0D7881039FF6A5D9FE788B0DF6096F751  : public NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATECHECKEDINT64_T62F4E4C0D7881039FF6A5D9FE788B0DF6096F751_H
#ifndef NEGATEDOUBLE_TEB21C1A1CFB080132BBC094719C1707E39818129_H
#define NEGATEDOUBLE_TEB21C1A1CFB080132BBC094719C1707E39818129_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateInstruction_NegateDouble
struct  NegateDouble_tEB21C1A1CFB080132BBC094719C1707E39818129  : public NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATEDOUBLE_TEB21C1A1CFB080132BBC094719C1707E39818129_H
#ifndef NEGATEINT16_T0A52CA1108EA11B82AF14C16EF69CAD1F4E6F06F_H
#define NEGATEINT16_T0A52CA1108EA11B82AF14C16EF69CAD1F4E6F06F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateInstruction_NegateInt16
struct  NegateInt16_t0A52CA1108EA11B82AF14C16EF69CAD1F4E6F06F  : public NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATEINT16_T0A52CA1108EA11B82AF14C16EF69CAD1F4E6F06F_H
#ifndef NEGATEINT32_T0307F3B623FF1805814FF44FFF20D93B1A07B7D7_H
#define NEGATEINT32_T0307F3B623FF1805814FF44FFF20D93B1A07B7D7_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateInstruction_NegateInt32
struct  NegateInt32_t0307F3B623FF1805814FF44FFF20D93B1A07B7D7  : public NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATEINT32_T0307F3B623FF1805814FF44FFF20D93B1A07B7D7_H
#ifndef NEGATEINT64_TA91CEC61799990B2BA28B59019ED6F5E110F01BE_H
#define NEGATEINT64_TA91CEC61799990B2BA28B59019ED6F5E110F01BE_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateInstruction_NegateInt64
struct  NegateInt64_tA91CEC61799990B2BA28B59019ED6F5E110F01BE  : public NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATEINT64_TA91CEC61799990B2BA28B59019ED6F5E110F01BE_H
#ifndef NEGATESINGLE_T0346B9CF38FEC55F076F0F926CA9D15358AAA39D_H
#define NEGATESINGLE_T0346B9CF38FEC55F076F0F926CA9D15358AAA39D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NegateInstruction_NegateSingle
struct  NegateSingle_t0346B9CF38FEC55F076F0F926CA9D15358AAA39D  : public NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEGATESINGLE_T0346B9CF38FEC55F076F0F926CA9D15358AAA39D_H
#ifndef NOTEQUALBOOLEAN_T58051ACE67B982A4607E113B63BF9A2045B3A0D1_H
#define NOTEQUALBOOLEAN_T58051ACE67B982A4607E113B63BF9A2045B3A0D1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualBoolean
struct  NotEqualBoolean_t58051ACE67B982A4607E113B63BF9A2045B3A0D1  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALBOOLEAN_T58051ACE67B982A4607E113B63BF9A2045B3A0D1_H
#ifndef NOTEQUALBYTE_T22DBE8F962F5553C40CA0548968F2456F999328F_H
#define NOTEQUALBYTE_T22DBE8F962F5553C40CA0548968F2456F999328F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualByte
struct  NotEqualByte_t22DBE8F962F5553C40CA0548968F2456F999328F  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALBYTE_T22DBE8F962F5553C40CA0548968F2456F999328F_H
#ifndef NOTEQUALBYTELIFTEDTONULL_T2186B392C304CF594D5D8F5A98C7DB773D9FE95B_H
#define NOTEQUALBYTELIFTEDTONULL_T2186B392C304CF594D5D8F5A98C7DB773D9FE95B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualByteLiftedToNull
struct  NotEqualByteLiftedToNull_t2186B392C304CF594D5D8F5A98C7DB773D9FE95B  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALBYTELIFTEDTONULL_T2186B392C304CF594D5D8F5A98C7DB773D9FE95B_H
#ifndef NOTEQUALCHAR_TBB0E58DB95E86FB602077BDFC44ADE6366C2EFCB_H
#define NOTEQUALCHAR_TBB0E58DB95E86FB602077BDFC44ADE6366C2EFCB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualChar
struct  NotEqualChar_tBB0E58DB95E86FB602077BDFC44ADE6366C2EFCB  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALCHAR_TBB0E58DB95E86FB602077BDFC44ADE6366C2EFCB_H
#ifndef NOTEQUALCHARLIFTEDTONULL_T239A80A1D7D012FED19FC9A006A42EDAE580E24E_H
#define NOTEQUALCHARLIFTEDTONULL_T239A80A1D7D012FED19FC9A006A42EDAE580E24E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualCharLiftedToNull
struct  NotEqualCharLiftedToNull_t239A80A1D7D012FED19FC9A006A42EDAE580E24E  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALCHARLIFTEDTONULL_T239A80A1D7D012FED19FC9A006A42EDAE580E24E_H
#ifndef NOTEQUALDOUBLE_T0A970539F6AD6333D5B93B417950F45F80A6C9E5_H
#define NOTEQUALDOUBLE_T0A970539F6AD6333D5B93B417950F45F80A6C9E5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualDouble
struct  NotEqualDouble_t0A970539F6AD6333D5B93B417950F45F80A6C9E5  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALDOUBLE_T0A970539F6AD6333D5B93B417950F45F80A6C9E5_H
#ifndef NOTEQUALDOUBLELIFTEDTONULL_T88AA46A67182F02C1271739B193F4C682925F89A_H
#define NOTEQUALDOUBLELIFTEDTONULL_T88AA46A67182F02C1271739B193F4C682925F89A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualDoubleLiftedToNull
struct  NotEqualDoubleLiftedToNull_t88AA46A67182F02C1271739B193F4C682925F89A  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALDOUBLELIFTEDTONULL_T88AA46A67182F02C1271739B193F4C682925F89A_H
#ifndef NOTEQUALINT16_T9320A8C2F7E760C3B5D969A4F0D249A97D866D72_H
#define NOTEQUALINT16_T9320A8C2F7E760C3B5D969A4F0D249A97D866D72_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualInt16
struct  NotEqualInt16_t9320A8C2F7E760C3B5D969A4F0D249A97D866D72  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALINT16_T9320A8C2F7E760C3B5D969A4F0D249A97D866D72_H
#ifndef NOTEQUALINT16LIFTEDTONULL_T23E8FEC38CAEEBA360B390611881D5C3BBD1E84D_H
#define NOTEQUALINT16LIFTEDTONULL_T23E8FEC38CAEEBA360B390611881D5C3BBD1E84D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualInt16LiftedToNull
struct  NotEqualInt16LiftedToNull_t23E8FEC38CAEEBA360B390611881D5C3BBD1E84D  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALINT16LIFTEDTONULL_T23E8FEC38CAEEBA360B390611881D5C3BBD1E84D_H
#ifndef NOTEQUALINT32_T60BF0D1DD6B8572DD259707B513A80D74C99819A_H
#define NOTEQUALINT32_T60BF0D1DD6B8572DD259707B513A80D74C99819A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualInt32
struct  NotEqualInt32_t60BF0D1DD6B8572DD259707B513A80D74C99819A  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALINT32_T60BF0D1DD6B8572DD259707B513A80D74C99819A_H
#ifndef NOTEQUALINT32LIFTEDTONULL_TE555712A9D3F4BF98519CD329F5CB8A681B91EBB_H
#define NOTEQUALINT32LIFTEDTONULL_TE555712A9D3F4BF98519CD329F5CB8A681B91EBB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualInt32LiftedToNull
struct  NotEqualInt32LiftedToNull_tE555712A9D3F4BF98519CD329F5CB8A681B91EBB  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALINT32LIFTEDTONULL_TE555712A9D3F4BF98519CD329F5CB8A681B91EBB_H
#ifndef NOTEQUALINT64_TBE6F2270444B5F12E77397F6C52AB6E38A2D8282_H
#define NOTEQUALINT64_TBE6F2270444B5F12E77397F6C52AB6E38A2D8282_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualInt64
struct  NotEqualInt64_tBE6F2270444B5F12E77397F6C52AB6E38A2D8282  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALINT64_TBE6F2270444B5F12E77397F6C52AB6E38A2D8282_H
#ifndef NOTEQUALINT64LIFTEDTONULL_TC4AD12EDF7F8063A9CDB14992F5AB3C4C945E549_H
#define NOTEQUALINT64LIFTEDTONULL_TC4AD12EDF7F8063A9CDB14992F5AB3C4C945E549_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualInt64LiftedToNull
struct  NotEqualInt64LiftedToNull_tC4AD12EDF7F8063A9CDB14992F5AB3C4C945E549  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALINT64LIFTEDTONULL_TC4AD12EDF7F8063A9CDB14992F5AB3C4C945E549_H
#ifndef NOTEQUALREFERENCE_TD6590F191934CECE53949DB7DB2292165E33E697_H
#define NOTEQUALREFERENCE_TD6590F191934CECE53949DB7DB2292165E33E697_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualReference
struct  NotEqualReference_tD6590F191934CECE53949DB7DB2292165E33E697  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALREFERENCE_TD6590F191934CECE53949DB7DB2292165E33E697_H
#ifndef NOTEQUALSBYTE_TF0EF826BE8E1EF9202F414245A63E7CE58643684_H
#define NOTEQUALSBYTE_TF0EF826BE8E1EF9202F414245A63E7CE58643684_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualSByte
struct  NotEqualSByte_tF0EF826BE8E1EF9202F414245A63E7CE58643684  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALSBYTE_TF0EF826BE8E1EF9202F414245A63E7CE58643684_H
#ifndef NOTEQUALSBYTELIFTEDTONULL_T041158AAAC8B72390959EF01009443CC2B066114_H
#define NOTEQUALSBYTELIFTEDTONULL_T041158AAAC8B72390959EF01009443CC2B066114_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualSByteLiftedToNull
struct  NotEqualSByteLiftedToNull_t041158AAAC8B72390959EF01009443CC2B066114  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALSBYTELIFTEDTONULL_T041158AAAC8B72390959EF01009443CC2B066114_H
#ifndef NOTEQUALSINGLE_TCFC865E9281557A504AF4E9366799C31E7B96B34_H
#define NOTEQUALSINGLE_TCFC865E9281557A504AF4E9366799C31E7B96B34_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualSingle
struct  NotEqualSingle_tCFC865E9281557A504AF4E9366799C31E7B96B34  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALSINGLE_TCFC865E9281557A504AF4E9366799C31E7B96B34_H
#ifndef NOTEQUALSINGLELIFTEDTONULL_TA4EE805B2A6EF81AAC8445A8553A413DC1977646_H
#define NOTEQUALSINGLELIFTEDTONULL_TA4EE805B2A6EF81AAC8445A8553A413DC1977646_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualSingleLiftedToNull
struct  NotEqualSingleLiftedToNull_tA4EE805B2A6EF81AAC8445A8553A413DC1977646  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALSINGLELIFTEDTONULL_TA4EE805B2A6EF81AAC8445A8553A413DC1977646_H
#ifndef NOTEQUALUINT16_T5528789185EBD200829DD94F6345EABDD38091E5_H
#define NOTEQUALUINT16_T5528789185EBD200829DD94F6345EABDD38091E5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualUInt16
struct  NotEqualUInt16_t5528789185EBD200829DD94F6345EABDD38091E5  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALUINT16_T5528789185EBD200829DD94F6345EABDD38091E5_H
#ifndef NOTEQUALUINT16LIFTEDTONULL_T5AA55542FAA48972EB006DA0886B2361D2EEECA5_H
#define NOTEQUALUINT16LIFTEDTONULL_T5AA55542FAA48972EB006DA0886B2361D2EEECA5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualUInt16LiftedToNull
struct  NotEqualUInt16LiftedToNull_t5AA55542FAA48972EB006DA0886B2361D2EEECA5  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALUINT16LIFTEDTONULL_T5AA55542FAA48972EB006DA0886B2361D2EEECA5_H
#ifndef NOTEQUALUINT32_T5FE468A3B814FC06D3168B41806BD13EC9E00872_H
#define NOTEQUALUINT32_T5FE468A3B814FC06D3168B41806BD13EC9E00872_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualUInt32
struct  NotEqualUInt32_t5FE468A3B814FC06D3168B41806BD13EC9E00872  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALUINT32_T5FE468A3B814FC06D3168B41806BD13EC9E00872_H
#ifndef NOTEQUALUINT32LIFTEDTONULL_T32090CC93C9FF3478011EAA646ACE9345D44A66D_H
#define NOTEQUALUINT32LIFTEDTONULL_T32090CC93C9FF3478011EAA646ACE9345D44A66D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualUInt32LiftedToNull
struct  NotEqualUInt32LiftedToNull_t32090CC93C9FF3478011EAA646ACE9345D44A66D  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALUINT32LIFTEDTONULL_T32090CC93C9FF3478011EAA646ACE9345D44A66D_H
#ifndef NOTEQUALUINT64_T18BB0075EE17B5D2058F0B954D4EB878DC12AE9B_H
#define NOTEQUALUINT64_T18BB0075EE17B5D2058F0B954D4EB878DC12AE9B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualUInt64
struct  NotEqualUInt64_t18BB0075EE17B5D2058F0B954D4EB878DC12AE9B  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALUINT64_T18BB0075EE17B5D2058F0B954D4EB878DC12AE9B_H
#ifndef NOTEQUALUINT64LIFTEDTONULL_T7E58447BF66836D1D1249BB671905ADC496DBF92_H
#define NOTEQUALUINT64LIFTEDTONULL_T7E58447BF66836D1D1249BB671905ADC496DBF92_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotEqualInstruction_NotEqualUInt64LiftedToNull
struct  NotEqualUInt64LiftedToNull_t7E58447BF66836D1D1249BB671905ADC496DBF92  : public NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTEQUALUINT64LIFTEDTONULL_T7E58447BF66836D1D1249BB671905ADC496DBF92_H
#ifndef NOTBOOLEAN_T4838FDD6842533B002F82324F392407030B40058_H
#define NOTBOOLEAN_T4838FDD6842533B002F82324F392407030B40058_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction_NotBoolean
struct  NotBoolean_t4838FDD6842533B002F82324F392407030B40058  : public NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTBOOLEAN_T4838FDD6842533B002F82324F392407030B40058_H
#ifndef NOTBYTE_T4D5C7642A7F66082066A07D7FC0EF12FA8871F97_H
#define NOTBYTE_T4D5C7642A7F66082066A07D7FC0EF12FA8871F97_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction_NotByte
struct  NotByte_t4D5C7642A7F66082066A07D7FC0EF12FA8871F97  : public NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTBYTE_T4D5C7642A7F66082066A07D7FC0EF12FA8871F97_H
#ifndef NOTINT16_T2B82E9B3217E790F0CD2D8BC2BA5FE6227639CB0_H
#define NOTINT16_T2B82E9B3217E790F0CD2D8BC2BA5FE6227639CB0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction_NotInt16
struct  NotInt16_t2B82E9B3217E790F0CD2D8BC2BA5FE6227639CB0  : public NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTINT16_T2B82E9B3217E790F0CD2D8BC2BA5FE6227639CB0_H
#ifndef NOTINT32_TD7CE64B9F4D6EEC501095E0A60C6B36A2BD3D1B9_H
#define NOTINT32_TD7CE64B9F4D6EEC501095E0A60C6B36A2BD3D1B9_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction_NotInt32
struct  NotInt32_tD7CE64B9F4D6EEC501095E0A60C6B36A2BD3D1B9  : public NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTINT32_TD7CE64B9F4D6EEC501095E0A60C6B36A2BD3D1B9_H
#ifndef NOTINT64_T112C82E4E2AE36E2C8432A96F377E899C24079BE_H
#define NOTINT64_T112C82E4E2AE36E2C8432A96F377E899C24079BE_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction_NotInt64
struct  NotInt64_t112C82E4E2AE36E2C8432A96F377E899C24079BE  : public NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTINT64_T112C82E4E2AE36E2C8432A96F377E899C24079BE_H
#ifndef NOTSBYTE_T383F6DA3412991F0BBF8895178A1980B5A015976_H
#define NOTSBYTE_T383F6DA3412991F0BBF8895178A1980B5A015976_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction_NotSByte
struct  NotSByte_t383F6DA3412991F0BBF8895178A1980B5A015976  : public NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTSBYTE_T383F6DA3412991F0BBF8895178A1980B5A015976_H
#ifndef NOTUINT16_T4DAF79904B8D2E99907DCD173252AAEF8ACC223E_H
#define NOTUINT16_T4DAF79904B8D2E99907DCD173252AAEF8ACC223E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction_NotUInt16
struct  NotUInt16_t4DAF79904B8D2E99907DCD173252AAEF8ACC223E  : public NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTUINT16_T4DAF79904B8D2E99907DCD173252AAEF8ACC223E_H
#ifndef NOTUINT32_T356DC91D8D86C5804270D7B23D2C47E448AD0567_H
#define NOTUINT32_T356DC91D8D86C5804270D7B23D2C47E448AD0567_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction_NotUInt32
struct  NotUInt32_t356DC91D8D86C5804270D7B23D2C47E448AD0567  : public NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTUINT32_T356DC91D8D86C5804270D7B23D2C47E448AD0567_H
#ifndef NOTUINT64_T9E02B41975AD8484725AF7AD4DC88AFFBD187027_H
#define NOTUINT64_T9E02B41975AD8484725AF7AD4DC88AFFBD187027_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NotInstruction_NotUInt64
struct  NotUInt64_t9E02B41975AD8484725AF7AD4DC88AFFBD187027  : public NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTUINT64_T9E02B41975AD8484725AF7AD4DC88AFFBD187027_H
#ifndef STORELOCALBOXEDINSTRUCTION_T3B9A7768D0F4804068F7062CFA3C623602A3A04F_H
#define STORELOCALBOXEDINSTRUCTION_T3B9A7768D0F4804068F7062CFA3C623602A3A04F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.StoreLocalBoxedInstruction
struct  StoreLocalBoxedInstruction_t3B9A7768D0F4804068F7062CFA3C623602A3A04F  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STORELOCALBOXEDINSTRUCTION_T3B9A7768D0F4804068F7062CFA3C623602A3A04F_H
#ifndef STORELOCALINSTRUCTION_T94B58B39018539E16958A89189617B9339F57FFD_H
#define STORELOCALINSTRUCTION_T94B58B39018539E16958A89189617B9339F57FFD_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.StoreLocalInstruction
struct  StoreLocalInstruction_t94B58B39018539E16958A89189617B9339F57FFD  : public LocalAccessInstruction_tBF932FCE7F4E923971CCA0751050DB88B668A4E9
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STORELOCALINSTRUCTION_T94B58B39018539E16958A89189617B9339F57FFD_H
#ifndef TYPECODE_T03ED52F888000DAF40C550C434F29F39A23D61C6_H
#define TYPECODE_T03ED52F888000DAF40C550C434F29F39A23D61C6_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.TypeCode
struct  TypeCode_t03ED52F888000DAF40C550C434F29F39A23D61C6 
{
public:
	// System.Int32 System.TypeCode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TypeCode_t03ED52F888000DAF40C550C434F29F39A23D61C6, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TYPECODE_T03ED52F888000DAF40C550C434F29F39A23D61C6_H
#ifndef IMMUTABLEBOX_T9C37F522C97EBE2147C14A7F363CA3315CA717DA_H
#define IMMUTABLEBOX_T9C37F522C97EBE2147C14A7F363CA3315CA717DA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.InitializeLocalInstruction_ImmutableBox
struct  ImmutableBox_t9C37F522C97EBE2147C14A7F363CA3315CA717DA  : public InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0
{
public:
	// System.Object System.Linq.Expressions.Interpreter.InitializeLocalInstruction_ImmutableBox::_defaultValue
	RuntimeObject * ____defaultValue_1;

public:
	inline static int32_t get_offset_of__defaultValue_1() { return static_cast<int32_t>(offsetof(ImmutableBox_t9C37F522C97EBE2147C14A7F363CA3315CA717DA, ____defaultValue_1)); }
	inline RuntimeObject * get__defaultValue_1() const { return ____defaultValue_1; }
	inline RuntimeObject ** get_address_of__defaultValue_1() { return &____defaultValue_1; }
	inline void set__defaultValue_1(RuntimeObject * value)
	{
		____defaultValue_1 = value;
		Il2CppCodeGenWriteBarrier((&____defaultValue_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // IMMUTABLEBOX_T9C37F522C97EBE2147C14A7F363CA3315CA717DA_H
#ifndef IMMUTABLEREFBOX_T2C4049FDA83F3310E1C037D4CC35D0E94E6E6E23_H
#define IMMUTABLEREFBOX_T2C4049FDA83F3310E1C037D4CC35D0E94E6E6E23_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.InitializeLocalInstruction_ImmutableRefBox
struct  ImmutableRefBox_t2C4049FDA83F3310E1C037D4CC35D0E94E6E6E23  : public InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // IMMUTABLEREFBOX_T2C4049FDA83F3310E1C037D4CC35D0E94E6E6E23_H
#ifndef IMMUTABLEVALUE_T4B1EFFC3539734D2C2D57744D88C0906A39F72B4_H
#define IMMUTABLEVALUE_T4B1EFFC3539734D2C2D57744D88C0906A39F72B4_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.InitializeLocalInstruction_ImmutableValue
struct  ImmutableValue_t4B1EFFC3539734D2C2D57744D88C0906A39F72B4  : public InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0
{
public:
	// System.Object System.Linq.Expressions.Interpreter.InitializeLocalInstruction_ImmutableValue::_defaultValue
	RuntimeObject * ____defaultValue_1;

public:
	inline static int32_t get_offset_of__defaultValue_1() { return static_cast<int32_t>(offsetof(ImmutableValue_t4B1EFFC3539734D2C2D57744D88C0906A39F72B4, ____defaultValue_1)); }
	inline RuntimeObject * get__defaultValue_1() const { return ____defaultValue_1; }
	inline RuntimeObject ** get_address_of__defaultValue_1() { return &____defaultValue_1; }
	inline void set__defaultValue_1(RuntimeObject * value)
	{
		____defaultValue_1 = value;
		Il2CppCodeGenWriteBarrier((&____defaultValue_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // IMMUTABLEVALUE_T4B1EFFC3539734D2C2D57744D88C0906A39F72B4_H
#ifndef MUTABLEBOX_T47B93D5F36BA347414301D7D92096554EEA5004E_H
#define MUTABLEBOX_T47B93D5F36BA347414301D7D92096554EEA5004E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.InitializeLocalInstruction_MutableBox
struct  MutableBox_t47B93D5F36BA347414301D7D92096554EEA5004E  : public InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0
{
public:
	// System.Type System.Linq.Expressions.Interpreter.InitializeLocalInstruction_MutableBox::_type
	Type_t * ____type_1;

public:
	inline static int32_t get_offset_of__type_1() { return static_cast<int32_t>(offsetof(MutableBox_t47B93D5F36BA347414301D7D92096554EEA5004E, ____type_1)); }
	inline Type_t * get__type_1() const { return ____type_1; }
	inline Type_t ** get_address_of__type_1() { return &____type_1; }
	inline void set__type_1(Type_t * value)
	{
		____type_1 = value;
		Il2CppCodeGenWriteBarrier((&____type_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MUTABLEBOX_T47B93D5F36BA347414301D7D92096554EEA5004E_H
#ifndef MUTABLEVALUE_TCF52A79ABA3CF05EB8130FA10519E3DC9A6E52B4_H
#define MUTABLEVALUE_TCF52A79ABA3CF05EB8130FA10519E3DC9A6E52B4_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.InitializeLocalInstruction_MutableValue
struct  MutableValue_tCF52A79ABA3CF05EB8130FA10519E3DC9A6E52B4  : public InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0
{
public:
	// System.Type System.Linq.Expressions.Interpreter.InitializeLocalInstruction_MutableValue::_type
	Type_t * ____type_1;

public:
	inline static int32_t get_offset_of__type_1() { return static_cast<int32_t>(offsetof(MutableValue_tCF52A79ABA3CF05EB8130FA10519E3DC9A6E52B4, ____type_1)); }
	inline Type_t * get__type_1() const { return ____type_1; }
	inline Type_t ** get_address_of__type_1() { return &____type_1; }
	inline void set__type_1(Type_t * value)
	{
		____type_1 = value;
		Il2CppCodeGenWriteBarrier((&____type_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MUTABLEVALUE_TCF52A79ABA3CF05EB8130FA10519E3DC9A6E52B4_H
#ifndef PARAMETER_TED3471398A9EE4FE31E9A27893219A8B0525031E_H
#define PARAMETER_TED3471398A9EE4FE31E9A27893219A8B0525031E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.InitializeLocalInstruction_Parameter
struct  Parameter_tED3471398A9EE4FE31E9A27893219A8B0525031E  : public InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // PARAMETER_TED3471398A9EE4FE31E9A27893219A8B0525031E_H
#ifndef PARAMETERBOX_T4DC349404AE42816A549522F80D0F0B32D524C4F_H
#define PARAMETERBOX_T4DC349404AE42816A549522F80D0F0B32D524C4F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.InitializeLocalInstruction_ParameterBox
struct  ParameterBox_t4DC349404AE42816A549522F80D0F0B32D524C4F  : public InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // PARAMETERBOX_T4DC349404AE42816A549522F80D0F0B32D524C4F_H
#ifndef REFERENCE_T956FFB63B5B01D7A9210A8D46562A0ECD44CCC0D_H
#define REFERENCE_T956FFB63B5B01D7A9210A8D46562A0ECD44CCC0D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.InitializeLocalInstruction_Reference
struct  Reference_t956FFB63B5B01D7A9210A8D46562A0ECD44CCC0D  : public InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // REFERENCE_T956FFB63B5B01D7A9210A8D46562A0ECD44CCC0D_H
#ifndef NUMERICCONVERTINSTRUCTION_T0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8_H
#define NUMERICCONVERTINSTRUCTION_T0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NumericConvertInstruction
struct  NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.TypeCode System.Linq.Expressions.Interpreter.NumericConvertInstruction::_from
	int32_t ____from_0;
	// System.TypeCode System.Linq.Expressions.Interpreter.NumericConvertInstruction::_to
	int32_t ____to_1;
	// System.Boolean System.Linq.Expressions.Interpreter.NumericConvertInstruction::_isLiftedToNull
	bool ____isLiftedToNull_2;

public:
	inline static int32_t get_offset_of__from_0() { return static_cast<int32_t>(offsetof(NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8, ____from_0)); }
	inline int32_t get__from_0() const { return ____from_0; }
	inline int32_t* get_address_of__from_0() { return &____from_0; }
	inline void set__from_0(int32_t value)
	{
		____from_0 = value;
	}

	inline static int32_t get_offset_of__to_1() { return static_cast<int32_t>(offsetof(NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8, ____to_1)); }
	inline int32_t get__to_1() const { return ____to_1; }
	inline int32_t* get_address_of__to_1() { return &____to_1; }
	inline void set__to_1(int32_t value)
	{
		____to_1 = value;
	}

	inline static int32_t get_offset_of__isLiftedToNull_2() { return static_cast<int32_t>(offsetof(NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8, ____isLiftedToNull_2)); }
	inline bool get__isLiftedToNull_2() const { return ____isLiftedToNull_2; }
	inline bool* get_address_of__isLiftedToNull_2() { return &____isLiftedToNull_2; }
	inline void set__isLiftedToNull_2(bool value)
	{
		____isLiftedToNull_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NUMERICCONVERTINSTRUCTION_T0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8_H
#ifndef CHECKED_T25268448663BBC4CCDA7B2474F66CD455C5F85E9_H
#define CHECKED_T25268448663BBC4CCDA7B2474F66CD455C5F85E9_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NumericConvertInstruction_Checked
struct  Checked_t25268448663BBC4CCDA7B2474F66CD455C5F85E9  : public NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CHECKED_T25268448663BBC4CCDA7B2474F66CD455C5F85E9_H
#ifndef UNCHECKED_T6252E98E473A93A4F1DAFBA7D6632B6F65F185E0_H
#define UNCHECKED_T6252E98E473A93A4F1DAFBA7D6632B6F65F185E0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NumericConvertInstruction_Unchecked
struct  Unchecked_t6252E98E473A93A4F1DAFBA7D6632B6F65F185E0  : public NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // UNCHECKED_T6252E98E473A93A4F1DAFBA7D6632B6F65F185E0_H





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2200 = { sizeof (LoadLocalInstruction_tDDC1A571CE7B66E853CFD81344A68291B3053AE5), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2201 = { sizeof (LoadLocalBoxedInstruction_t8D4E88459DEA7475CAD9F4C8FD001B862CFFB40A), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2202 = { sizeof (LoadLocalFromClosureInstruction_t7A80323CE72C7E44154797B5979695CA52374BEA), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2203 = { sizeof (LoadLocalFromClosureBoxedInstruction_tB50E923BC630A74B41389D002E0FCB56FE55E41F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2204 = { sizeof (AssignLocalInstruction_tDD7CBDF01A0522841D8A61738C87D6A8118FE05F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2205 = { sizeof (StoreLocalInstruction_t94B58B39018539E16958A89189617B9339F57FFD), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2206 = { sizeof (AssignLocalBoxedInstruction_t5B8CA20241F46D5CB13CB66884EA1842DB0A2709), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2207 = { sizeof (StoreLocalBoxedInstruction_t3B9A7768D0F4804068F7062CFA3C623602A3A04F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2208 = { sizeof (AssignLocalToClosureInstruction_tEF834FAA17D2143AF81A991440502FFEA26206AA), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2209 = { sizeof (ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A), -1, sizeof(ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2209[1] = 
{
	ValueTypeCopyInstruction_t23E216D257169A6157250599F73FE44C2E1F3F8A_StaticFields::get_offset_of_Instruction_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2210 = { sizeof (InitializeLocalInstruction_tA5278193CB1D2BA3D47C8D306B2DFAE0C19158B0), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2211 = { sizeof (Reference_t956FFB63B5B01D7A9210A8D46562A0ECD44CCC0D), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2212 = { sizeof (ImmutableValue_t4B1EFFC3539734D2C2D57744D88C0906A39F72B4), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2212[1] = 
{
	ImmutableValue_t4B1EFFC3539734D2C2D57744D88C0906A39F72B4::get_offset_of__defaultValue_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2213 = { sizeof (ImmutableBox_t9C37F522C97EBE2147C14A7F363CA3315CA717DA), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2213[1] = 
{
	ImmutableBox_t9C37F522C97EBE2147C14A7F363CA3315CA717DA::get_offset_of__defaultValue_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2214 = { sizeof (ImmutableRefBox_t2C4049FDA83F3310E1C037D4CC35D0E94E6E6E23), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2215 = { sizeof (ParameterBox_t4DC349404AE42816A549522F80D0F0B32D524C4F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2216 = { sizeof (Parameter_tED3471398A9EE4FE31E9A27893219A8B0525031E), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2217 = { sizeof (MutableValue_tCF52A79ABA3CF05EB8130FA10519E3DC9A6E52B4), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2217[1] = 
{
	MutableValue_tCF52A79ABA3CF05EB8130FA10519E3DC9A6E52B4::get_offset_of__type_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2218 = { sizeof (MutableBox_t47B93D5F36BA347414301D7D92096554EEA5004E), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2218[1] = 
{
	MutableBox_t47B93D5F36BA347414301D7D92096554EEA5004E::get_offset_of__type_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2219 = { sizeof (RuntimeVariablesInstruction_t35C1BC0FF252C67827DA8018F16B089F7140D65A), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2219[1] = 
{
	RuntimeVariablesInstruction_t35C1BC0FF252C67827DA8018F16B089F7140D65A::get_offset_of__count_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2220 = { sizeof (LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2220[2] = 
{
	LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752::get_offset_of_Index_0(),
	LocalVariable_t4876B01B79DC675A325C66D1B473DD480C5FB752::get_offset_of__flags_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2221 = { sizeof (LocalDefinition_t6EB6DABA8D559626495A9D03AFEE82848A905C2D)+ sizeof (RuntimeObject), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2221[2] = 
{
	LocalDefinition_t6EB6DABA8D559626495A9D03AFEE82848A905C2D::get_offset_of_U3CIndexU3Ek__BackingField_0() + static_cast<int32_t>(sizeof(RuntimeObject)),
	LocalDefinition_t6EB6DABA8D559626495A9D03AFEE82848A905C2D::get_offset_of_U3CParameterU3Ek__BackingField_1() + static_cast<int32_t>(sizeof(RuntimeObject)),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2222 = { sizeof (LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2222[4] = 
{
	LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E::get_offset_of__variables_0(),
	LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E::get_offset_of__closureVariables_1(),
	LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E::get_offset_of__localCount_2(),
	LocalVariables_t6AA7555A7C165901095619CB9684D735C348201E::get_offset_of__maxLocalCount_3(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2223 = { sizeof (VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2223[5] = 
{
	VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E::get_offset_of_Start_0(),
	VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E::get_offset_of_Stop_1(),
	VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E::get_offset_of_Variable_2(),
	VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E::get_offset_of_Parent_3(),
	VariableScope_tC8F26DB0A896598371ABF001A5842281D95F925E::get_offset_of_ChildScopes_4(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2224 = { sizeof (ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983), -1, sizeof(ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2224[8] = 
{
	ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields::get_offset_of_s_Int16_0(),
	ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields::get_offset_of_s_Int32_1(),
	ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields::get_offset_of_s_Int64_2(),
	ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields::get_offset_of_s_UInt16_3(),
	ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields::get_offset_of_s_UInt32_4(),
	ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields::get_offset_of_s_UInt64_5(),
	ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields::get_offset_of_s_Single_6(),
	ModuloInstruction_t914B2DFCC1E53A553279FDF9B63E39228E669983_StaticFields::get_offset_of_s_Double_7(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2225 = { sizeof (ModuloInt16_tAFE469D9CAD954A27438F7E3CA75C2726CADF96A), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2226 = { sizeof (ModuloInt32_tCCF0F7428C09D9907618F688AA9505721BA135DF), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2227 = { sizeof (ModuloInt64_t3115FC5838345A011DCE569F0B9B9252A5C246F1), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2228 = { sizeof (ModuloUInt16_t8AFCF86880F449F62399531FBB760D34B0A3BC06), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2229 = { sizeof (ModuloUInt32_tBA94D2CD224FBF3CAD5ACAACA936E73E31A8967D), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2230 = { sizeof (ModuloUInt64_tE6C7B141AAA28C593C870B94D8B929C93A73A8FB), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2231 = { sizeof (ModuloSingle_t3F0BE8201876C08493F66D99B5D4293807037A51), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2232 = { sizeof (ModuloDouble_t1509ED265C338A7AE04D6562ABB2CCF1B4B775D0), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2233 = { sizeof (MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3), -1, sizeof(MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2233[8] = 
{
	MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields::get_offset_of_s_Int16_0(),
	MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields::get_offset_of_s_Int32_1(),
	MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields::get_offset_of_s_Int64_2(),
	MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields::get_offset_of_s_UInt16_3(),
	MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields::get_offset_of_s_UInt32_4(),
	MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields::get_offset_of_s_UInt64_5(),
	MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields::get_offset_of_s_Single_6(),
	MulInstruction_tB50503026C7505F69BE66FA64659386DD51A40A3_StaticFields::get_offset_of_s_Double_7(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2234 = { sizeof (MulInt16_t735B0FD60D31F17800B1B9644F873CBD4EB97EC3), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2235 = { sizeof (MulInt32_t8E3552E45AFAA0231E8E6680C045A99DD7EEC75F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2236 = { sizeof (MulInt64_t5EE8DEC75AD17248FE0E0BD36E45C7616368262F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2237 = { sizeof (MulUInt16_t4872AE4C8C7899FD511902E4EAC06F47C7D76BE4), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2238 = { sizeof (MulUInt32_t02CB609A82516E9D984B55A233003AAFAD254D26), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2239 = { sizeof (MulUInt64_t9551BBBF596994F0C598BFAA95600C57ECD845A1), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2240 = { sizeof (MulSingle_t3B8EE9EB50F5A852AFC482F13D81475228C197BE), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2241 = { sizeof (MulDouble_t376B753EC98DAB83F7ABC4C9870D5E46810EEF49), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2242 = { sizeof (MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F), -1, sizeof(MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2242[6] = 
{
	MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields::get_offset_of_s_Int16_0(),
	MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields::get_offset_of_s_Int32_1(),
	MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields::get_offset_of_s_Int64_2(),
	MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields::get_offset_of_s_UInt16_3(),
	MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields::get_offset_of_s_UInt32_4(),
	MulOvfInstruction_t0CE20D88AC8B21E4B48858DD7644F8CC9FCD775F_StaticFields::get_offset_of_s_UInt64_5(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2243 = { sizeof (MulOvfInt16_tFA2495B40DEBFF451C7A390E07D4C92AD0160A95), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2244 = { sizeof (MulOvfInt32_tD27C55A50D8B4B9972EE9D1AD6DE132AFF522F95), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2245 = { sizeof (MulOvfInt64_t4CF3151A1DF49176246634F103318EA5C5FC039D), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2246 = { sizeof (MulOvfUInt16_t21FE81AFFA64286D3EF9E71BD049E23C838E6D80), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2247 = { sizeof (MulOvfUInt32_t582609E5C011F0FEDB7C6CD037A4FD48A35CA189), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2248 = { sizeof (MulOvfUInt64_t95B0CD36EBD8F30FB99F3C485DB49C82F07E8489), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2249 = { sizeof (NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1), -1, sizeof(NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2249[5] = 
{
	NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields::get_offset_of_s_Int16_0(),
	NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields::get_offset_of_s_Int32_1(),
	NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields::get_offset_of_s_Int64_2(),
	NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields::get_offset_of_s_Single_3(),
	NegateInstruction_t31A1B4199FB9B7A64604441569CC6247CEEF19E1_StaticFields::get_offset_of_s_Double_4(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2250 = { sizeof (NegateInt16_t0A52CA1108EA11B82AF14C16EF69CAD1F4E6F06F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2251 = { sizeof (NegateInt32_t0307F3B623FF1805814FF44FFF20D93B1A07B7D7), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2252 = { sizeof (NegateInt64_tA91CEC61799990B2BA28B59019ED6F5E110F01BE), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2253 = { sizeof (NegateSingle_t0346B9CF38FEC55F076F0F926CA9D15358AAA39D), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2254 = { sizeof (NegateDouble_tEB21C1A1CFB080132BBC094719C1707E39818129), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2255 = { sizeof (NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810), -1, sizeof(NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2255[3] = 
{
	NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_StaticFields::get_offset_of_s_Int16_0(),
	NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_StaticFields::get_offset_of_s_Int32_1(),
	NegateCheckedInstruction_tF2C2982B9B43BC0D4F61A152B6FF3FF64DAAD810_StaticFields::get_offset_of_s_Int64_2(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2256 = { sizeof (NegateCheckedInt32_t67257D954DC2ADAEA9263975B278D2B878261B05), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2257 = { sizeof (NegateCheckedInt16_t351B4E3F193182CE658C4F35EA78E179DE5458F1), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2258 = { sizeof (NegateCheckedInt64_t62F4E4C0D7881039FF6A5D9FE788B0DF6096F751), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2259 = { sizeof (NewInstruction_t3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2259[2] = 
{
	NewInstruction_t3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E::get_offset_of__constructor_0(),
	NewInstruction_t3AE88AB1BBAA872BA06F91814C0AA0C24AA8FB9E::get_offset_of__argumentCount_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2260 = { sizeof (ByRefNewInstruction_tF7C1A4D0859C569E7E4F00DA196EC318DA655477), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2260[1] = 
{
	ByRefNewInstruction_tF7C1A4D0859C569E7E4F00DA196EC318DA655477::get_offset_of__byrefArgs_2(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2261 = { sizeof (NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3), -1, sizeof(NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2261[24] = 
{
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_reference_0(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Boolean_1(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_SByte_2(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Int16_3(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Char_4(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Int32_5(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Int64_6(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Byte_7(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_UInt16_8(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_UInt32_9(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_UInt64_10(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Single_11(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Double_12(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_SByteLiftedToNull_13(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Int16LiftedToNull_14(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_CharLiftedToNull_15(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Int32LiftedToNull_16(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_Int64LiftedToNull_17(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_ByteLiftedToNull_18(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_UInt16LiftedToNull_19(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_UInt32LiftedToNull_20(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_UInt64LiftedToNull_21(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_SingleLiftedToNull_22(),
	NotEqualInstruction_tFD850A1858371685EE6F07767D4EBF7DAACE24F3_StaticFields::get_offset_of_s_DoubleLiftedToNull_23(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2262 = { sizeof (NotEqualBoolean_t58051ACE67B982A4607E113B63BF9A2045B3A0D1), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2263 = { sizeof (NotEqualSByte_tF0EF826BE8E1EF9202F414245A63E7CE58643684), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2264 = { sizeof (NotEqualInt16_t9320A8C2F7E760C3B5D969A4F0D249A97D866D72), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2265 = { sizeof (NotEqualChar_tBB0E58DB95E86FB602077BDFC44ADE6366C2EFCB), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2266 = { sizeof (NotEqualInt32_t60BF0D1DD6B8572DD259707B513A80D74C99819A), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2267 = { sizeof (NotEqualInt64_tBE6F2270444B5F12E77397F6C52AB6E38A2D8282), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2268 = { sizeof (NotEqualByte_t22DBE8F962F5553C40CA0548968F2456F999328F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2269 = { sizeof (NotEqualUInt16_t5528789185EBD200829DD94F6345EABDD38091E5), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2270 = { sizeof (NotEqualUInt32_t5FE468A3B814FC06D3168B41806BD13EC9E00872), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2271 = { sizeof (NotEqualUInt64_t18BB0075EE17B5D2058F0B954D4EB878DC12AE9B), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2272 = { sizeof (NotEqualSingle_tCFC865E9281557A504AF4E9366799C31E7B96B34), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2273 = { sizeof (NotEqualDouble_t0A970539F6AD6333D5B93B417950F45F80A6C9E5), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2274 = { sizeof (NotEqualReference_tD6590F191934CECE53949DB7DB2292165E33E697), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2275 = { sizeof (NotEqualSByteLiftedToNull_t041158AAAC8B72390959EF01009443CC2B066114), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2276 = { sizeof (NotEqualInt16LiftedToNull_t23E8FEC38CAEEBA360B390611881D5C3BBD1E84D), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2277 = { sizeof (NotEqualCharLiftedToNull_t239A80A1D7D012FED19FC9A006A42EDAE580E24E), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2278 = { sizeof (NotEqualInt32LiftedToNull_tE555712A9D3F4BF98519CD329F5CB8A681B91EBB), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2279 = { sizeof (NotEqualInt64LiftedToNull_tC4AD12EDF7F8063A9CDB14992F5AB3C4C945E549), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2280 = { sizeof (NotEqualByteLiftedToNull_t2186B392C304CF594D5D8F5A98C7DB773D9FE95B), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2281 = { sizeof (NotEqualUInt16LiftedToNull_t5AA55542FAA48972EB006DA0886B2361D2EEECA5), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2282 = { sizeof (NotEqualUInt32LiftedToNull_t32090CC93C9FF3478011EAA646ACE9345D44A66D), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2283 = { sizeof (NotEqualUInt64LiftedToNull_t7E58447BF66836D1D1249BB671905ADC496DBF92), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2284 = { sizeof (NotEqualSingleLiftedToNull_tA4EE805B2A6EF81AAC8445A8553A413DC1977646), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2285 = { sizeof (NotEqualDoubleLiftedToNull_t88AA46A67182F02C1271739B193F4C682925F89A), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2286 = { sizeof (NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394), -1, sizeof(NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2286[9] = 
{
	NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields::get_offset_of_s_Boolean_0(),
	NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields::get_offset_of_s_Int64_1(),
	NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields::get_offset_of_s_Int32_2(),
	NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields::get_offset_of_s_Int16_3(),
	NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields::get_offset_of_s_UInt64_4(),
	NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields::get_offset_of_s_UInt32_5(),
	NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields::get_offset_of_s_UInt16_6(),
	NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields::get_offset_of_s_Byte_7(),
	NotInstruction_t4D8FFB3F6775BD663A1B8BDF961E616B665F4394_StaticFields::get_offset_of_s_SByte_8(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2287 = { sizeof (NotBoolean_t4838FDD6842533B002F82324F392407030B40058), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2288 = { sizeof (NotInt64_t112C82E4E2AE36E2C8432A96F377E899C24079BE), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2289 = { sizeof (NotInt32_tD7CE64B9F4D6EEC501095E0A60C6B36A2BD3D1B9), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2290 = { sizeof (NotInt16_t2B82E9B3217E790F0CD2D8BC2BA5FE6227639CB0), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2291 = { sizeof (NotUInt64_t9E02B41975AD8484725AF7AD4DC88AFFBD187027), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2292 = { sizeof (NotUInt32_t356DC91D8D86C5804270D7B23D2C47E448AD0567), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2293 = { sizeof (NotUInt16_t4DAF79904B8D2E99907DCD173252AAEF8ACC223E), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2294 = { sizeof (NotByte_t4D5C7642A7F66082066A07D7FC0EF12FA8871F97), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2295 = { sizeof (NotSByte_t383F6DA3412991F0BBF8895178A1980B5A015976), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2296 = { sizeof (NullCheckInstruction_tE91E4297947DDC4D25DB22D27BB64BB912940D80), -1, sizeof(NullCheckInstruction_tE91E4297947DDC4D25DB22D27BB64BB912940D80_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2296[1] = 
{
	NullCheckInstruction_tE91E4297947DDC4D25DB22D27BB64BB912940D80_StaticFields::get_offset_of_Instance_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2297 = { sizeof (NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2297[3] = 
{
	NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8::get_offset_of__from_0(),
	NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8::get_offset_of__to_1(),
	NumericConvertInstruction_t0BFC2548B21AADFDCDA617AD2F2EF0437D02EAA8::get_offset_of__isLiftedToNull_2(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2298 = { sizeof (Unchecked_t6252E98E473A93A4F1DAFBA7D6632B6F65F185E0), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2299 = { sizeof (Checked_t25268448663BBC4CCDA7B2474F66CD455C5F85E9), -1, 0, 0 };
#ifdef __clang__
#pragma clang diagnostic pop
#endif
