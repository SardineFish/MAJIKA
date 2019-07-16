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


// System.Collections.Generic.Dictionary`2<System.String,System.Int32>
struct Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226;
// System.Linq.Expressions.Interpreter.ByRefUpdater[]
struct ByRefUpdaterU5BU5D_tDB1EB5674027EBA8F3752913C79D156F07CF97F7;
// System.Linq.Expressions.Interpreter.EnterFaultInstruction[]
struct EnterFaultInstructionU5BU5D_tC830C8A5F8062774F0051C0CA3F885CC8699D441;
// System.Linq.Expressions.Interpreter.EnterFinallyInstruction[]
struct EnterFinallyInstructionU5BU5D_t634E9112AFFB398E4426B95DCADBC97C41C2897C;
// System.Linq.Expressions.Interpreter.GotoInstruction[]
struct GotoInstructionU5BU5D_tF5B2267B62BBE20C5B087DF3F8598FB24713E4C7;
// System.Linq.Expressions.Interpreter.Instruction
struct Instruction_t235F1D5246CE88164576679572E0E858988436C3;
// System.Linq.Expressions.Interpreter.Instruction[]
struct InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756;
// System.Linq.Expressions.Interpreter.Instruction[][][]
struct InstructionU5BU5DU5BU5DU5BU5D_tC4888457FC83FAC515EA54CF8CBA6788F5210CE8;
// System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction[]
struct LeaveExceptionHandlerInstructionU5BU5D_t0B7D9B28B5BFECB8F7334C9E01A23076CEF2184D;
// System.Linq.Expressions.Interpreter.TryCatchFinallyHandler
struct TryCatchFinallyHandler_t7AB1E0FF1C486495BF0E0EEDD327548799F1D7D8;
// System.Linq.Expressions.Interpreter.TryFaultHandler
struct TryFaultHandler_t3F2F0A73BFC198B9142027A7B98F7A29FC6CDE13;
// System.Reflection.ConstructorInfo
struct ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF;
// System.Reflection.FieldInfo
struct FieldInfo_t;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Runtime.CompilerServices.StrongBox`1<System.Int32>
struct StrongBox_1_tF235ABC61FF5FFF748E7FA114FC17E4192B954CF;
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
#ifndef BRANCHLABEL_T214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87_H
#define BRANCHLABEL_T214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.BranchLabel
struct  BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Expressions.Interpreter.BranchLabel::_targetIndex
	int32_t ____targetIndex_0;
	// System.Int32 System.Linq.Expressions.Interpreter.BranchLabel::_stackDepth
	int32_t ____stackDepth_1;
	// System.Int32 System.Linq.Expressions.Interpreter.BranchLabel::_continuationStackDepth
	int32_t ____continuationStackDepth_2;
	// System.Collections.Generic.List`1<System.Int32> System.Linq.Expressions.Interpreter.BranchLabel::_forwardBranchFixups
	List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * ____forwardBranchFixups_3;
	// System.Int32 System.Linq.Expressions.Interpreter.BranchLabel::<LabelIndex>k__BackingField
	int32_t ___U3CLabelIndexU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of__targetIndex_0() { return static_cast<int32_t>(offsetof(BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87, ____targetIndex_0)); }
	inline int32_t get__targetIndex_0() const { return ____targetIndex_0; }
	inline int32_t* get_address_of__targetIndex_0() { return &____targetIndex_0; }
	inline void set__targetIndex_0(int32_t value)
	{
		____targetIndex_0 = value;
	}

	inline static int32_t get_offset_of__stackDepth_1() { return static_cast<int32_t>(offsetof(BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87, ____stackDepth_1)); }
	inline int32_t get__stackDepth_1() const { return ____stackDepth_1; }
	inline int32_t* get_address_of__stackDepth_1() { return &____stackDepth_1; }
	inline void set__stackDepth_1(int32_t value)
	{
		____stackDepth_1 = value;
	}

	inline static int32_t get_offset_of__continuationStackDepth_2() { return static_cast<int32_t>(offsetof(BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87, ____continuationStackDepth_2)); }
	inline int32_t get__continuationStackDepth_2() const { return ____continuationStackDepth_2; }
	inline int32_t* get_address_of__continuationStackDepth_2() { return &____continuationStackDepth_2; }
	inline void set__continuationStackDepth_2(int32_t value)
	{
		____continuationStackDepth_2 = value;
	}

	inline static int32_t get_offset_of__forwardBranchFixups_3() { return static_cast<int32_t>(offsetof(BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87, ____forwardBranchFixups_3)); }
	inline List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * get__forwardBranchFixups_3() const { return ____forwardBranchFixups_3; }
	inline List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 ** get_address_of__forwardBranchFixups_3() { return &____forwardBranchFixups_3; }
	inline void set__forwardBranchFixups_3(List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * value)
	{
		____forwardBranchFixups_3 = value;
		Il2CppCodeGenWriteBarrier((&____forwardBranchFixups_3), value);
	}

	inline static int32_t get_offset_of_U3CLabelIndexU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87, ___U3CLabelIndexU3Ek__BackingField_4)); }
	inline int32_t get_U3CLabelIndexU3Ek__BackingField_4() const { return ___U3CLabelIndexU3Ek__BackingField_4; }
	inline int32_t* get_address_of_U3CLabelIndexU3Ek__BackingField_4() { return &___U3CLabelIndexU3Ek__BackingField_4; }
	inline void set_U3CLabelIndexU3Ek__BackingField_4(int32_t value)
	{
		___U3CLabelIndexU3Ek__BackingField_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BRANCHLABEL_T214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87_H
#ifndef CONVERTHELPER_T7A009D993A13DC4734775DFE75D15E7964E477DA_H
#define CONVERTHELPER_T7A009D993A13DC4734775DFE75D15E7964E477DA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ConvertHelper
struct  ConvertHelper_t7A009D993A13DC4734775DFE75D15E7964E477DA  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CONVERTHELPER_T7A009D993A13DC4734775DFE75D15E7964E477DA_H
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
#ifndef ANDINSTRUCTION_T2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_H
#define ANDINSTRUCTION_T2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AndInstruction
struct  AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.AndInstruction::s_SByte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_SByte_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.AndInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.AndInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.AndInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.AndInstruction::s_Byte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Byte_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.AndInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_5;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.AndInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_6;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.AndInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_7;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.AndInstruction::s_Boolean
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Boolean_8;

public:
	inline static int32_t get_offset_of_s_SByte_0() { return static_cast<int32_t>(offsetof(AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields, ___s_SByte_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_SByte_0() const { return ___s_SByte_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_SByte_0() { return &___s_SByte_0; }
	inline void set_s_SByte_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_SByte_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_SByte_0), value);
	}

	inline static int32_t get_offset_of_s_Int16_1() { return static_cast<int32_t>(offsetof(AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields, ___s_Int16_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_1() const { return ___s_Int16_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_1() { return &___s_Int16_1; }
	inline void set_s_Int16_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_1), value);
	}

	inline static int32_t get_offset_of_s_Int32_2() { return static_cast<int32_t>(offsetof(AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields, ___s_Int32_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_2() const { return ___s_Int32_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_2() { return &___s_Int32_2; }
	inline void set_s_Int32_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_2), value);
	}

	inline static int32_t get_offset_of_s_Int64_3() { return static_cast<int32_t>(offsetof(AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields, ___s_Int64_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_3() const { return ___s_Int64_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_3() { return &___s_Int64_3; }
	inline void set_s_Int64_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_3), value);
	}

	inline static int32_t get_offset_of_s_Byte_4() { return static_cast<int32_t>(offsetof(AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields, ___s_Byte_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Byte_4() const { return ___s_Byte_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Byte_4() { return &___s_Byte_4; }
	inline void set_s_Byte_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Byte_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_Byte_4), value);
	}

	inline static int32_t get_offset_of_s_UInt16_5() { return static_cast<int32_t>(offsetof(AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields, ___s_UInt16_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_5() const { return ___s_UInt16_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_5() { return &___s_UInt16_5; }
	inline void set_s_UInt16_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_5), value);
	}

	inline static int32_t get_offset_of_s_UInt32_6() { return static_cast<int32_t>(offsetof(AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields, ___s_UInt32_6)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_6() const { return ___s_UInt32_6; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_6() { return &___s_UInt32_6; }
	inline void set_s_UInt32_6(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_6 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_6), value);
	}

	inline static int32_t get_offset_of_s_UInt64_7() { return static_cast<int32_t>(offsetof(AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields, ___s_UInt64_7)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_7() const { return ___s_UInt64_7; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_7() { return &___s_UInt64_7; }
	inline void set_s_UInt64_7(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_7 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_7), value);
	}

	inline static int32_t get_offset_of_s_Boolean_8() { return static_cast<int32_t>(offsetof(AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_StaticFields, ___s_Boolean_8)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Boolean_8() const { return ___s_Boolean_8; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Boolean_8() { return &___s_Boolean_8; }
	inline void set_s_Boolean_8(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Boolean_8 = value;
		Il2CppCodeGenWriteBarrier((&___s_Boolean_8), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANDINSTRUCTION_T2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC_H
#ifndef ARRAYLENGTHINSTRUCTION_T0B377310312E7649BBE3DF102AD6A6BF2C451214_H
#define ARRAYLENGTHINSTRUCTION_T0B377310312E7649BBE3DF102AD6A6BF2C451214_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ArrayLengthInstruction
struct  ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.ArrayLengthInstruction System.Linq.Expressions.Interpreter.ArrayLengthInstruction::Instance
	ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214 * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214_StaticFields, ___Instance_0)); }
	inline ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214 * get_Instance_0() const { return ___Instance_0; }
	inline ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214 ** get_address_of_Instance_0() { return &___Instance_0; }
	inline void set_Instance_0(ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214 * value)
	{
		___Instance_0 = value;
		Il2CppCodeGenWriteBarrier((&___Instance_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ARRAYLENGTHINSTRUCTION_T0B377310312E7649BBE3DF102AD6A6BF2C451214_H
#ifndef CALLINSTRUCTION_TE463EE38C397DCD089226727826DF7B48B5C0526_H
#define CALLINSTRUCTION_TE463EE38C397DCD089226727826DF7B48B5C0526_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.CallInstruction
struct  CallInstruction_tE463EE38C397DCD089226727826DF7B48B5C0526  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CALLINSTRUCTION_TE463EE38C397DCD089226727826DF7B48B5C0526_H
#ifndef DECREMENTINSTRUCTION_T7348431A8488943B1B7DFE21A919984F51CDB38E_H
#define DECREMENTINSTRUCTION_T7348431A8488943B1B7DFE21A919984F51CDB38E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DecrementInstruction
struct  DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DecrementInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DecrementInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DecrementInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DecrementInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DecrementInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DecrementInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_5;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DecrementInstruction::s_Single
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Single_6;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DecrementInstruction::s_Double
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Double_7;

public:
	inline static int32_t get_offset_of_s_Int16_0() { return static_cast<int32_t>(offsetof(DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields, ___s_Int16_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_0() const { return ___s_Int16_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_0() { return &___s_Int16_0; }
	inline void set_s_Int16_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_0), value);
	}

	inline static int32_t get_offset_of_s_Int32_1() { return static_cast<int32_t>(offsetof(DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields, ___s_Int32_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_1() const { return ___s_Int32_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_1() { return &___s_Int32_1; }
	inline void set_s_Int32_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_1), value);
	}

	inline static int32_t get_offset_of_s_Int64_2() { return static_cast<int32_t>(offsetof(DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields, ___s_Int64_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_2() const { return ___s_Int64_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_2() { return &___s_Int64_2; }
	inline void set_s_Int64_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_2), value);
	}

	inline static int32_t get_offset_of_s_UInt16_3() { return static_cast<int32_t>(offsetof(DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields, ___s_UInt16_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_3() const { return ___s_UInt16_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_3() { return &___s_UInt16_3; }
	inline void set_s_UInt16_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_3), value);
	}

	inline static int32_t get_offset_of_s_UInt32_4() { return static_cast<int32_t>(offsetof(DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields, ___s_UInt32_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_4() const { return ___s_UInt32_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_4() { return &___s_UInt32_4; }
	inline void set_s_UInt32_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_4), value);
	}

	inline static int32_t get_offset_of_s_UInt64_5() { return static_cast<int32_t>(offsetof(DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields, ___s_UInt64_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_5() const { return ___s_UInt64_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_5() { return &___s_UInt64_5; }
	inline void set_s_UInt64_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_5), value);
	}

	inline static int32_t get_offset_of_s_Single_6() { return static_cast<int32_t>(offsetof(DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields, ___s_Single_6)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Single_6() const { return ___s_Single_6; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Single_6() { return &___s_Single_6; }
	inline void set_s_Single_6(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Single_6 = value;
		Il2CppCodeGenWriteBarrier((&___s_Single_6), value);
	}

	inline static int32_t get_offset_of_s_Double_7() { return static_cast<int32_t>(offsetof(DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields, ___s_Double_7)); }
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
#endif // DECREMENTINSTRUCTION_T7348431A8488943B1B7DFE21A919984F51CDB38E_H
#ifndef DEFAULTVALUEINSTRUCTION_T68CA6DB41069E83803AE7100FF7ADB87FE5FA7DE_H
#define DEFAULTVALUEINSTRUCTION_T68CA6DB41069E83803AE7100FF7ADB87FE5FA7DE_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DefaultValueInstruction
struct  DefaultValueInstruction_t68CA6DB41069E83803AE7100FF7ADB87FE5FA7DE  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Type System.Linq.Expressions.Interpreter.DefaultValueInstruction::_type
	Type_t * ____type_0;

public:
	inline static int32_t get_offset_of__type_0() { return static_cast<int32_t>(offsetof(DefaultValueInstruction_t68CA6DB41069E83803AE7100FF7ADB87FE5FA7DE, ____type_0)); }
	inline Type_t * get__type_0() const { return ____type_0; }
	inline Type_t ** get_address_of__type_0() { return &____type_0; }
	inline void set__type_0(Type_t * value)
	{
		____type_0 = value;
		Il2CppCodeGenWriteBarrier((&____type_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DEFAULTVALUEINSTRUCTION_T68CA6DB41069E83803AE7100FF7ADB87FE5FA7DE_H
#ifndef DIVINSTRUCTION_TE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_H
#define DIVINSTRUCTION_TE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DivInstruction
struct  DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DivInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DivInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DivInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DivInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DivInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DivInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_5;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DivInstruction::s_Single
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Single_6;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.DivInstruction::s_Double
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Double_7;

public:
	inline static int32_t get_offset_of_s_Int16_0() { return static_cast<int32_t>(offsetof(DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields, ___s_Int16_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_0() const { return ___s_Int16_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_0() { return &___s_Int16_0; }
	inline void set_s_Int16_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_0), value);
	}

	inline static int32_t get_offset_of_s_Int32_1() { return static_cast<int32_t>(offsetof(DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields, ___s_Int32_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_1() const { return ___s_Int32_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_1() { return &___s_Int32_1; }
	inline void set_s_Int32_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_1), value);
	}

	inline static int32_t get_offset_of_s_Int64_2() { return static_cast<int32_t>(offsetof(DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields, ___s_Int64_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_2() const { return ___s_Int64_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_2() { return &___s_Int64_2; }
	inline void set_s_Int64_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_2), value);
	}

	inline static int32_t get_offset_of_s_UInt16_3() { return static_cast<int32_t>(offsetof(DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields, ___s_UInt16_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_3() const { return ___s_UInt16_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_3() { return &___s_UInt16_3; }
	inline void set_s_UInt16_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_3), value);
	}

	inline static int32_t get_offset_of_s_UInt32_4() { return static_cast<int32_t>(offsetof(DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields, ___s_UInt32_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_4() const { return ___s_UInt32_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_4() { return &___s_UInt32_4; }
	inline void set_s_UInt32_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_4), value);
	}

	inline static int32_t get_offset_of_s_UInt64_5() { return static_cast<int32_t>(offsetof(DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields, ___s_UInt64_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_5() const { return ___s_UInt64_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_5() { return &___s_UInt64_5; }
	inline void set_s_UInt64_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_5), value);
	}

	inline static int32_t get_offset_of_s_Single_6() { return static_cast<int32_t>(offsetof(DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields, ___s_Single_6)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Single_6() const { return ___s_Single_6; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Single_6() { return &___s_Single_6; }
	inline void set_s_Single_6(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Single_6 = value;
		Il2CppCodeGenWriteBarrier((&___s_Single_6), value);
	}

	inline static int32_t get_offset_of_s_Double_7() { return static_cast<int32_t>(offsetof(DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields, ___s_Double_7)); }
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
#endif // DIVINSTRUCTION_TE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_H
#ifndef ENTEREXCEPTIONFILTERINSTRUCTION_T862DD68E4F70EFC981EAC32E900EB7DC9604C3EC_H
#define ENTEREXCEPTIONFILTERINSTRUCTION_T862DD68E4F70EFC981EAC32E900EB7DC9604C3EC_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EnterExceptionFilterInstruction
struct  EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.EnterExceptionFilterInstruction System.Linq.Expressions.Interpreter.EnterExceptionFilterInstruction::Instance
	EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC_StaticFields, ___Instance_0)); }
	inline EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC * get_Instance_0() const { return ___Instance_0; }
	inline EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC ** get_address_of_Instance_0() { return &___Instance_0; }
	inline void set_Instance_0(EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC * value)
	{
		___Instance_0 = value;
		Il2CppCodeGenWriteBarrier((&___Instance_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENTEREXCEPTIONFILTERINSTRUCTION_T862DD68E4F70EFC981EAC32E900EB7DC9604C3EC_H
#ifndef ENTEREXCEPTIONHANDLERINSTRUCTION_T96904E7A70E349971A58634403840A0C3ECDFBF9_H
#define ENTEREXCEPTIONHANDLERINSTRUCTION_T96904E7A70E349971A58634403840A0C3ECDFBF9_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction
struct  EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Boolean System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction::_hasValue
	bool ____hasValue_2;

public:
	inline static int32_t get_offset_of__hasValue_2() { return static_cast<int32_t>(offsetof(EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9, ____hasValue_2)); }
	inline bool get__hasValue_2() const { return ____hasValue_2; }
	inline bool* get_address_of__hasValue_2() { return &____hasValue_2; }
	inline void set__hasValue_2(bool value)
	{
		____hasValue_2 = value;
	}
};

struct EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction::Void
	EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9 * ___Void_0;
	// System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction::NonVoid
	EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9 * ___NonVoid_1;

public:
	inline static int32_t get_offset_of_Void_0() { return static_cast<int32_t>(offsetof(EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9_StaticFields, ___Void_0)); }
	inline EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9 * get_Void_0() const { return ___Void_0; }
	inline EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9 ** get_address_of_Void_0() { return &___Void_0; }
	inline void set_Void_0(EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9 * value)
	{
		___Void_0 = value;
		Il2CppCodeGenWriteBarrier((&___Void_0), value);
	}

	inline static int32_t get_offset_of_NonVoid_1() { return static_cast<int32_t>(offsetof(EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9_StaticFields, ___NonVoid_1)); }
	inline EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9 * get_NonVoid_1() const { return ___NonVoid_1; }
	inline EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9 ** get_address_of_NonVoid_1() { return &___NonVoid_1; }
	inline void set_NonVoid_1(EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9 * value)
	{
		___NonVoid_1 = value;
		Il2CppCodeGenWriteBarrier((&___NonVoid_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENTEREXCEPTIONHANDLERINSTRUCTION_T96904E7A70E349971A58634403840A0C3ECDFBF9_H
#ifndef EQUALINSTRUCTION_TAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_H
#define EQUALINSTRUCTION_TAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction
struct  EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_reference
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_reference_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Boolean
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Boolean_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_SByte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_SByte_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Char
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Char_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_5;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_6;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Byte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Byte_7;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_8;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_9;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_10;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Single
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Single_11;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Double
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Double_12;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_BooleanLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_BooleanLiftedToNull_13;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_SByteLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_SByteLiftedToNull_14;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Int16LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16LiftedToNull_15;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_CharLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_CharLiftedToNull_16;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Int32LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32LiftedToNull_17;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_Int64LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64LiftedToNull_18;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_ByteLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_ByteLiftedToNull_19;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_UInt16LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16LiftedToNull_20;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_UInt32LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32LiftedToNull_21;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_UInt64LiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64LiftedToNull_22;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_SingleLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_SingleLiftedToNull_23;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.EqualInstruction::s_DoubleLiftedToNull
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_DoubleLiftedToNull_24;

public:
	inline static int32_t get_offset_of_s_reference_0() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_reference_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_reference_0() const { return ___s_reference_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_reference_0() { return &___s_reference_0; }
	inline void set_s_reference_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_reference_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_reference_0), value);
	}

	inline static int32_t get_offset_of_s_Boolean_1() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Boolean_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Boolean_1() const { return ___s_Boolean_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Boolean_1() { return &___s_Boolean_1; }
	inline void set_s_Boolean_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Boolean_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Boolean_1), value);
	}

	inline static int32_t get_offset_of_s_SByte_2() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_SByte_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_SByte_2() const { return ___s_SByte_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_SByte_2() { return &___s_SByte_2; }
	inline void set_s_SByte_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_SByte_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_SByte_2), value);
	}

	inline static int32_t get_offset_of_s_Int16_3() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Int16_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_3() const { return ___s_Int16_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_3() { return &___s_Int16_3; }
	inline void set_s_Int16_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_3), value);
	}

	inline static int32_t get_offset_of_s_Char_4() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Char_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Char_4() const { return ___s_Char_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Char_4() { return &___s_Char_4; }
	inline void set_s_Char_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Char_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_Char_4), value);
	}

	inline static int32_t get_offset_of_s_Int32_5() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Int32_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_5() const { return ___s_Int32_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_5() { return &___s_Int32_5; }
	inline void set_s_Int32_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_5), value);
	}

	inline static int32_t get_offset_of_s_Int64_6() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Int64_6)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_6() const { return ___s_Int64_6; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_6() { return &___s_Int64_6; }
	inline void set_s_Int64_6(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_6 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_6), value);
	}

	inline static int32_t get_offset_of_s_Byte_7() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Byte_7)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Byte_7() const { return ___s_Byte_7; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Byte_7() { return &___s_Byte_7; }
	inline void set_s_Byte_7(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Byte_7 = value;
		Il2CppCodeGenWriteBarrier((&___s_Byte_7), value);
	}

	inline static int32_t get_offset_of_s_UInt16_8() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_UInt16_8)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_8() const { return ___s_UInt16_8; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_8() { return &___s_UInt16_8; }
	inline void set_s_UInt16_8(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_8 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_8), value);
	}

	inline static int32_t get_offset_of_s_UInt32_9() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_UInt32_9)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_9() const { return ___s_UInt32_9; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_9() { return &___s_UInt32_9; }
	inline void set_s_UInt32_9(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_9 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_9), value);
	}

	inline static int32_t get_offset_of_s_UInt64_10() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_UInt64_10)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_10() const { return ___s_UInt64_10; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_10() { return &___s_UInt64_10; }
	inline void set_s_UInt64_10(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_10 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_10), value);
	}

	inline static int32_t get_offset_of_s_Single_11() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Single_11)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Single_11() const { return ___s_Single_11; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Single_11() { return &___s_Single_11; }
	inline void set_s_Single_11(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Single_11 = value;
		Il2CppCodeGenWriteBarrier((&___s_Single_11), value);
	}

	inline static int32_t get_offset_of_s_Double_12() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Double_12)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Double_12() const { return ___s_Double_12; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Double_12() { return &___s_Double_12; }
	inline void set_s_Double_12(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Double_12 = value;
		Il2CppCodeGenWriteBarrier((&___s_Double_12), value);
	}

	inline static int32_t get_offset_of_s_BooleanLiftedToNull_13() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_BooleanLiftedToNull_13)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_BooleanLiftedToNull_13() const { return ___s_BooleanLiftedToNull_13; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_BooleanLiftedToNull_13() { return &___s_BooleanLiftedToNull_13; }
	inline void set_s_BooleanLiftedToNull_13(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_BooleanLiftedToNull_13 = value;
		Il2CppCodeGenWriteBarrier((&___s_BooleanLiftedToNull_13), value);
	}

	inline static int32_t get_offset_of_s_SByteLiftedToNull_14() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_SByteLiftedToNull_14)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_SByteLiftedToNull_14() const { return ___s_SByteLiftedToNull_14; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_SByteLiftedToNull_14() { return &___s_SByteLiftedToNull_14; }
	inline void set_s_SByteLiftedToNull_14(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_SByteLiftedToNull_14 = value;
		Il2CppCodeGenWriteBarrier((&___s_SByteLiftedToNull_14), value);
	}

	inline static int32_t get_offset_of_s_Int16LiftedToNull_15() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Int16LiftedToNull_15)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16LiftedToNull_15() const { return ___s_Int16LiftedToNull_15; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16LiftedToNull_15() { return &___s_Int16LiftedToNull_15; }
	inline void set_s_Int16LiftedToNull_15(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16LiftedToNull_15 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16LiftedToNull_15), value);
	}

	inline static int32_t get_offset_of_s_CharLiftedToNull_16() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_CharLiftedToNull_16)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_CharLiftedToNull_16() const { return ___s_CharLiftedToNull_16; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_CharLiftedToNull_16() { return &___s_CharLiftedToNull_16; }
	inline void set_s_CharLiftedToNull_16(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_CharLiftedToNull_16 = value;
		Il2CppCodeGenWriteBarrier((&___s_CharLiftedToNull_16), value);
	}

	inline static int32_t get_offset_of_s_Int32LiftedToNull_17() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Int32LiftedToNull_17)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32LiftedToNull_17() const { return ___s_Int32LiftedToNull_17; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32LiftedToNull_17() { return &___s_Int32LiftedToNull_17; }
	inline void set_s_Int32LiftedToNull_17(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32LiftedToNull_17 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32LiftedToNull_17), value);
	}

	inline static int32_t get_offset_of_s_Int64LiftedToNull_18() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_Int64LiftedToNull_18)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64LiftedToNull_18() const { return ___s_Int64LiftedToNull_18; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64LiftedToNull_18() { return &___s_Int64LiftedToNull_18; }
	inline void set_s_Int64LiftedToNull_18(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64LiftedToNull_18 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64LiftedToNull_18), value);
	}

	inline static int32_t get_offset_of_s_ByteLiftedToNull_19() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_ByteLiftedToNull_19)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_ByteLiftedToNull_19() const { return ___s_ByteLiftedToNull_19; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_ByteLiftedToNull_19() { return &___s_ByteLiftedToNull_19; }
	inline void set_s_ByteLiftedToNull_19(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_ByteLiftedToNull_19 = value;
		Il2CppCodeGenWriteBarrier((&___s_ByteLiftedToNull_19), value);
	}

	inline static int32_t get_offset_of_s_UInt16LiftedToNull_20() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_UInt16LiftedToNull_20)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16LiftedToNull_20() const { return ___s_UInt16LiftedToNull_20; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16LiftedToNull_20() { return &___s_UInt16LiftedToNull_20; }
	inline void set_s_UInt16LiftedToNull_20(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16LiftedToNull_20 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16LiftedToNull_20), value);
	}

	inline static int32_t get_offset_of_s_UInt32LiftedToNull_21() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_UInt32LiftedToNull_21)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32LiftedToNull_21() const { return ___s_UInt32LiftedToNull_21; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32LiftedToNull_21() { return &___s_UInt32LiftedToNull_21; }
	inline void set_s_UInt32LiftedToNull_21(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32LiftedToNull_21 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32LiftedToNull_21), value);
	}

	inline static int32_t get_offset_of_s_UInt64LiftedToNull_22() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_UInt64LiftedToNull_22)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64LiftedToNull_22() const { return ___s_UInt64LiftedToNull_22; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64LiftedToNull_22() { return &___s_UInt64LiftedToNull_22; }
	inline void set_s_UInt64LiftedToNull_22(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64LiftedToNull_22 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64LiftedToNull_22), value);
	}

	inline static int32_t get_offset_of_s_SingleLiftedToNull_23() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_SingleLiftedToNull_23)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_SingleLiftedToNull_23() const { return ___s_SingleLiftedToNull_23; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_SingleLiftedToNull_23() { return &___s_SingleLiftedToNull_23; }
	inline void set_s_SingleLiftedToNull_23(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_SingleLiftedToNull_23 = value;
		Il2CppCodeGenWriteBarrier((&___s_SingleLiftedToNull_23), value);
	}

	inline static int32_t get_offset_of_s_DoubleLiftedToNull_24() { return static_cast<int32_t>(offsetof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields, ___s_DoubleLiftedToNull_24)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_DoubleLiftedToNull_24() const { return ___s_DoubleLiftedToNull_24; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_DoubleLiftedToNull_24() { return &___s_DoubleLiftedToNull_24; }
	inline void set_s_DoubleLiftedToNull_24(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_DoubleLiftedToNull_24 = value;
		Il2CppCodeGenWriteBarrier((&___s_DoubleLiftedToNull_24), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALINSTRUCTION_TAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_H
#ifndef EXCLUSIVEORINSTRUCTION_TE00833508F8745D38AC819C06FB26BDE59E5E91B_H
#define EXCLUSIVEORINSTRUCTION_TE00833508F8745D38AC819C06FB26BDE59E5E91B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction
struct  ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ExclusiveOrInstruction::s_SByte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_SByte_0;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ExclusiveOrInstruction::s_Int16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int16_1;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ExclusiveOrInstruction::s_Int32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int32_2;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ExclusiveOrInstruction::s_Int64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Int64_3;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ExclusiveOrInstruction::s_Byte
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Byte_4;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ExclusiveOrInstruction::s_UInt16
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt16_5;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ExclusiveOrInstruction::s_UInt32
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt32_6;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ExclusiveOrInstruction::s_UInt64
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_UInt64_7;
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.ExclusiveOrInstruction::s_Boolean
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___s_Boolean_8;

public:
	inline static int32_t get_offset_of_s_SByte_0() { return static_cast<int32_t>(offsetof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields, ___s_SByte_0)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_SByte_0() const { return ___s_SByte_0; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_SByte_0() { return &___s_SByte_0; }
	inline void set_s_SByte_0(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_SByte_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_SByte_0), value);
	}

	inline static int32_t get_offset_of_s_Int16_1() { return static_cast<int32_t>(offsetof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields, ___s_Int16_1)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int16_1() const { return ___s_Int16_1; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int16_1() { return &___s_Int16_1; }
	inline void set_s_Int16_1(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int16_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int16_1), value);
	}

	inline static int32_t get_offset_of_s_Int32_2() { return static_cast<int32_t>(offsetof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields, ___s_Int32_2)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int32_2() const { return ___s_Int32_2; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int32_2() { return &___s_Int32_2; }
	inline void set_s_Int32_2(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int32_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int32_2), value);
	}

	inline static int32_t get_offset_of_s_Int64_3() { return static_cast<int32_t>(offsetof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields, ___s_Int64_3)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Int64_3() const { return ___s_Int64_3; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Int64_3() { return &___s_Int64_3; }
	inline void set_s_Int64_3(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Int64_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_Int64_3), value);
	}

	inline static int32_t get_offset_of_s_Byte_4() { return static_cast<int32_t>(offsetof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields, ___s_Byte_4)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Byte_4() const { return ___s_Byte_4; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Byte_4() { return &___s_Byte_4; }
	inline void set_s_Byte_4(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Byte_4 = value;
		Il2CppCodeGenWriteBarrier((&___s_Byte_4), value);
	}

	inline static int32_t get_offset_of_s_UInt16_5() { return static_cast<int32_t>(offsetof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields, ___s_UInt16_5)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt16_5() const { return ___s_UInt16_5; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt16_5() { return &___s_UInt16_5; }
	inline void set_s_UInt16_5(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt16_5 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt16_5), value);
	}

	inline static int32_t get_offset_of_s_UInt32_6() { return static_cast<int32_t>(offsetof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields, ___s_UInt32_6)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt32_6() const { return ___s_UInt32_6; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt32_6() { return &___s_UInt32_6; }
	inline void set_s_UInt32_6(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt32_6 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt32_6), value);
	}

	inline static int32_t get_offset_of_s_UInt64_7() { return static_cast<int32_t>(offsetof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields, ___s_UInt64_7)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_UInt64_7() const { return ___s_UInt64_7; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_UInt64_7() { return &___s_UInt64_7; }
	inline void set_s_UInt64_7(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_UInt64_7 = value;
		Il2CppCodeGenWriteBarrier((&___s_UInt64_7), value);
	}

	inline static int32_t get_offset_of_s_Boolean_8() { return static_cast<int32_t>(offsetof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields, ___s_Boolean_8)); }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 * get_s_Boolean_8() const { return ___s_Boolean_8; }
	inline Instruction_t235F1D5246CE88164576679572E0E858988436C3 ** get_address_of_s_Boolean_8() { return &___s_Boolean_8; }
	inline void set_s_Boolean_8(Instruction_t235F1D5246CE88164576679572E0E858988436C3 * value)
	{
		___s_Boolean_8 = value;
		Il2CppCodeGenWriteBarrier((&___s_Boolean_8), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORINSTRUCTION_TE00833508F8745D38AC819C06FB26BDE59E5E91B_H
#ifndef FIELDINSTRUCTION_TE97586CE791336617EC1BA6284504911B7558E5A_H
#define FIELDINSTRUCTION_TE97586CE791336617EC1BA6284504911B7558E5A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.FieldInstruction
struct  FieldInstruction_tE97586CE791336617EC1BA6284504911B7558E5A  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Reflection.FieldInfo System.Linq.Expressions.Interpreter.FieldInstruction::_field
	FieldInfo_t * ____field_0;

public:
	inline static int32_t get_offset_of__field_0() { return static_cast<int32_t>(offsetof(FieldInstruction_tE97586CE791336617EC1BA6284504911B7558E5A, ____field_0)); }
	inline FieldInfo_t * get__field_0() const { return ____field_0; }
	inline FieldInfo_t ** get_address_of__field_0() { return &____field_0; }
	inline void set__field_0(FieldInfo_t * value)
	{
		____field_0 = value;
		Il2CppCodeGenWriteBarrier((&____field_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // FIELDINSTRUCTION_TE97586CE791336617EC1BA6284504911B7558E5A_H
#ifndef GETARRAYITEMINSTRUCTION_T39F1BF484A9130A193CB6ED96E751AA0CF99506E_H
#define GETARRAYITEMINSTRUCTION_T39F1BF484A9130A193CB6ED96E751AA0CF99506E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.GetArrayItemInstruction
struct  GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.GetArrayItemInstruction System.Linq.Expressions.Interpreter.GetArrayItemInstruction::Instance
	GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E_StaticFields, ___Instance_0)); }
	inline GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E * get_Instance_0() const { return ___Instance_0; }
	inline GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E ** get_address_of_Instance_0() { return &___Instance_0; }
	inline void set_Instance_0(GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E * value)
	{
		___Instance_0 = value;
		Il2CppCodeGenWriteBarrier((&___Instance_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // GETARRAYITEMINSTRUCTION_T39F1BF484A9130A193CB6ED96E751AA0CF99506E_H
#ifndef INDEXEDBRANCHINSTRUCTION_T518A5A2689EC6F443B8556FDD556C6594827A77E_H
#define INDEXEDBRANCHINSTRUCTION_T518A5A2689EC6F443B8556FDD556C6594827A77E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.IndexedBranchInstruction
struct  IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Int32 System.Linq.Expressions.Interpreter.IndexedBranchInstruction::_labelIndex
	int32_t ____labelIndex_0;

public:
	inline static int32_t get_offset_of__labelIndex_0() { return static_cast<int32_t>(offsetof(IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E, ____labelIndex_0)); }
	inline int32_t get__labelIndex_0() const { return ____labelIndex_0; }
	inline int32_t* get_address_of__labelIndex_0() { return &____labelIndex_0; }
	inline void set__labelIndex_0(int32_t value)
	{
		____labelIndex_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INDEXEDBRANCHINSTRUCTION_T518A5A2689EC6F443B8556FDD556C6594827A77E_H
#ifndef LEAVEEXCEPTIONFILTERINSTRUCTION_T14D166B81741912F5FAB6EADFF81EFC16E971C26_H
#define LEAVEEXCEPTIONFILTERINSTRUCTION_T14D166B81741912F5FAB6EADFF81EFC16E971C26_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LeaveExceptionFilterInstruction
struct  LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.LeaveExceptionFilterInstruction System.Linq.Expressions.Interpreter.LeaveExceptionFilterInstruction::Instance
	LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26 * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26_StaticFields, ___Instance_0)); }
	inline LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26 * get_Instance_0() const { return ___Instance_0; }
	inline LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26 ** get_address_of_Instance_0() { return &___Instance_0; }
	inline void set_Instance_0(LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26 * value)
	{
		___Instance_0 = value;
		Il2CppCodeGenWriteBarrier((&___Instance_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LEAVEEXCEPTIONFILTERINSTRUCTION_T14D166B81741912F5FAB6EADFF81EFC16E971C26_H
#ifndef LEAVEFAULTINSTRUCTION_T1539C9677C606E3190D4E0B0DAB51CC44A794DD0_H
#define LEAVEFAULTINSTRUCTION_T1539C9677C606E3190D4E0B0DAB51CC44A794DD0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LeaveFaultInstruction
struct  LeaveFaultInstruction_t1539C9677C606E3190D4E0B0DAB51CC44A794DD0  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct LeaveFaultInstruction_t1539C9677C606E3190D4E0B0DAB51CC44A794DD0_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.LeaveFaultInstruction::Instance
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(LeaveFaultInstruction_t1539C9677C606E3190D4E0B0DAB51CC44A794DD0_StaticFields, ___Instance_0)); }
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
#endif // LEAVEFAULTINSTRUCTION_T1539C9677C606E3190D4E0B0DAB51CC44A794DD0_H
#ifndef LEAVEFINALLYINSTRUCTION_TA5945AD963154A41F127F635BB13A911E632B290_H
#define LEAVEFINALLYINSTRUCTION_TA5945AD963154A41F127F635BB13A911E632B290_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LeaveFinallyInstruction
struct  LeaveFinallyInstruction_tA5945AD963154A41F127F635BB13A911E632B290  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct LeaveFinallyInstruction_tA5945AD963154A41F127F635BB13A911E632B290_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction System.Linq.Expressions.Interpreter.LeaveFinallyInstruction::Instance
	Instruction_t235F1D5246CE88164576679572E0E858988436C3 * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(LeaveFinallyInstruction_tA5945AD963154A41F127F635BB13A911E632B290_StaticFields, ___Instance_0)); }
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
#endif // LEAVEFINALLYINSTRUCTION_TA5945AD963154A41F127F635BB13A911E632B290_H
#ifndef NEWARRAYBOUNDSINSTRUCTION_T5A4E6C08C0B27F679C1F780FD83B5CFB93AB50EF_H
#define NEWARRAYBOUNDSINSTRUCTION_T5A4E6C08C0B27F679C1F780FD83B5CFB93AB50EF_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NewArrayBoundsInstruction
struct  NewArrayBoundsInstruction_t5A4E6C08C0B27F679C1F780FD83B5CFB93AB50EF  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Type System.Linq.Expressions.Interpreter.NewArrayBoundsInstruction::_elementType
	Type_t * ____elementType_0;
	// System.Int32 System.Linq.Expressions.Interpreter.NewArrayBoundsInstruction::_rank
	int32_t ____rank_1;

public:
	inline static int32_t get_offset_of__elementType_0() { return static_cast<int32_t>(offsetof(NewArrayBoundsInstruction_t5A4E6C08C0B27F679C1F780FD83B5CFB93AB50EF, ____elementType_0)); }
	inline Type_t * get__elementType_0() const { return ____elementType_0; }
	inline Type_t ** get_address_of__elementType_0() { return &____elementType_0; }
	inline void set__elementType_0(Type_t * value)
	{
		____elementType_0 = value;
		Il2CppCodeGenWriteBarrier((&____elementType_0), value);
	}

	inline static int32_t get_offset_of__rank_1() { return static_cast<int32_t>(offsetof(NewArrayBoundsInstruction_t5A4E6C08C0B27F679C1F780FD83B5CFB93AB50EF, ____rank_1)); }
	inline int32_t get__rank_1() const { return ____rank_1; }
	inline int32_t* get_address_of__rank_1() { return &____rank_1; }
	inline void set__rank_1(int32_t value)
	{
		____rank_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEWARRAYBOUNDSINSTRUCTION_T5A4E6C08C0B27F679C1F780FD83B5CFB93AB50EF_H
#ifndef NEWARRAYINITINSTRUCTION_T5750C6A24A7B12F49C15D59B7C0ADBD5E523CC5F_H
#define NEWARRAYINITINSTRUCTION_T5750C6A24A7B12F49C15D59B7C0ADBD5E523CC5F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NewArrayInitInstruction
struct  NewArrayInitInstruction_t5750C6A24A7B12F49C15D59B7C0ADBD5E523CC5F  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Type System.Linq.Expressions.Interpreter.NewArrayInitInstruction::_elementType
	Type_t * ____elementType_0;
	// System.Int32 System.Linq.Expressions.Interpreter.NewArrayInitInstruction::_elementCount
	int32_t ____elementCount_1;

public:
	inline static int32_t get_offset_of__elementType_0() { return static_cast<int32_t>(offsetof(NewArrayInitInstruction_t5750C6A24A7B12F49C15D59B7C0ADBD5E523CC5F, ____elementType_0)); }
	inline Type_t * get__elementType_0() const { return ____elementType_0; }
	inline Type_t ** get_address_of__elementType_0() { return &____elementType_0; }
	inline void set__elementType_0(Type_t * value)
	{
		____elementType_0 = value;
		Il2CppCodeGenWriteBarrier((&____elementType_0), value);
	}

	inline static int32_t get_offset_of__elementCount_1() { return static_cast<int32_t>(offsetof(NewArrayInitInstruction_t5750C6A24A7B12F49C15D59B7C0ADBD5E523CC5F, ____elementCount_1)); }
	inline int32_t get__elementCount_1() const { return ____elementCount_1; }
	inline int32_t* get_address_of__elementCount_1() { return &____elementCount_1; }
	inline void set__elementCount_1(int32_t value)
	{
		____elementCount_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEWARRAYINITINSTRUCTION_T5750C6A24A7B12F49C15D59B7C0ADBD5E523CC5F_H
#ifndef NEWARRAYINSTRUCTION_TBDA16F86FF6FB99F63B65FC558463C111AC61B05_H
#define NEWARRAYINSTRUCTION_TBDA16F86FF6FB99F63B65FC558463C111AC61B05_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.NewArrayInstruction
struct  NewArrayInstruction_tBDA16F86FF6FB99F63B65FC558463C111AC61B05  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Type System.Linq.Expressions.Interpreter.NewArrayInstruction::_elementType
	Type_t * ____elementType_0;

public:
	inline static int32_t get_offset_of__elementType_0() { return static_cast<int32_t>(offsetof(NewArrayInstruction_tBDA16F86FF6FB99F63B65FC558463C111AC61B05, ____elementType_0)); }
	inline Type_t * get__elementType_0() const { return ____elementType_0; }
	inline Type_t ** get_address_of__elementType_0() { return &____elementType_0; }
	inline void set__elementType_0(Type_t * value)
	{
		____elementType_0 = value;
		Il2CppCodeGenWriteBarrier((&____elementType_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NEWARRAYINSTRUCTION_TBDA16F86FF6FB99F63B65FC558463C111AC61B05_H
#ifndef OFFSETINSTRUCTION_TC6482B97ABF5D496066EBCFB48B452115DF00063_H
#define OFFSETINSTRUCTION_TC6482B97ABF5D496066EBCFB48B452115DF00063_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.OffsetInstruction
struct  OffsetInstruction_tC6482B97ABF5D496066EBCFB48B452115DF00063  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Int32 System.Linq.Expressions.Interpreter.OffsetInstruction::_offset
	int32_t ____offset_0;

public:
	inline static int32_t get_offset_of__offset_0() { return static_cast<int32_t>(offsetof(OffsetInstruction_tC6482B97ABF5D496066EBCFB48B452115DF00063, ____offset_0)); }
	inline int32_t get__offset_0() const { return ____offset_0; }
	inline int32_t* get_address_of__offset_0() { return &____offset_0; }
	inline void set__offset_0(int32_t value)
	{
		____offset_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // OFFSETINSTRUCTION_TC6482B97ABF5D496066EBCFB48B452115DF00063_H
#ifndef RUNTIMELABEL_T0FAE2EECA36B182898675A50204615C6149BD9E3_H
#define RUNTIMELABEL_T0FAE2EECA36B182898675A50204615C6149BD9E3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.RuntimeLabel
struct  RuntimeLabel_t0FAE2EECA36B182898675A50204615C6149BD9E3 
{
public:
	// System.Int32 System.Linq.Expressions.Interpreter.RuntimeLabel::Index
	int32_t ___Index_0;
	// System.Int32 System.Linq.Expressions.Interpreter.RuntimeLabel::StackDepth
	int32_t ___StackDepth_1;
	// System.Int32 System.Linq.Expressions.Interpreter.RuntimeLabel::ContinuationStackDepth
	int32_t ___ContinuationStackDepth_2;

public:
	inline static int32_t get_offset_of_Index_0() { return static_cast<int32_t>(offsetof(RuntimeLabel_t0FAE2EECA36B182898675A50204615C6149BD9E3, ___Index_0)); }
	inline int32_t get_Index_0() const { return ___Index_0; }
	inline int32_t* get_address_of_Index_0() { return &___Index_0; }
	inline void set_Index_0(int32_t value)
	{
		___Index_0 = value;
	}

	inline static int32_t get_offset_of_StackDepth_1() { return static_cast<int32_t>(offsetof(RuntimeLabel_t0FAE2EECA36B182898675A50204615C6149BD9E3, ___StackDepth_1)); }
	inline int32_t get_StackDepth_1() const { return ___StackDepth_1; }
	inline int32_t* get_address_of_StackDepth_1() { return &___StackDepth_1; }
	inline void set_StackDepth_1(int32_t value)
	{
		___StackDepth_1 = value;
	}

	inline static int32_t get_offset_of_ContinuationStackDepth_2() { return static_cast<int32_t>(offsetof(RuntimeLabel_t0FAE2EECA36B182898675A50204615C6149BD9E3, ___ContinuationStackDepth_2)); }
	inline int32_t get_ContinuationStackDepth_2() const { return ___ContinuationStackDepth_2; }
	inline int32_t* get_address_of_ContinuationStackDepth_2() { return &___ContinuationStackDepth_2; }
	inline void set_ContinuationStackDepth_2(int32_t value)
	{
		___ContinuationStackDepth_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMELABEL_T0FAE2EECA36B182898675A50204615C6149BD9E3_H
#ifndef SETARRAYITEMINSTRUCTION_TADF1CC4120E6E891C701BDC2C9445B8D7A639478_H
#define SETARRAYITEMINSTRUCTION_TADF1CC4120E6E891C701BDC2C9445B8D7A639478_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.SetArrayItemInstruction
struct  SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:

public:
};

struct SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.SetArrayItemInstruction System.Linq.Expressions.Interpreter.SetArrayItemInstruction::Instance
	SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478 * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478_StaticFields, ___Instance_0)); }
	inline SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478 * get_Instance_0() const { return ___Instance_0; }
	inline SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478 ** get_address_of_Instance_0() { return &___Instance_0; }
	inline void set_Instance_0(SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478 * value)
	{
		___Instance_0 = value;
		Il2CppCodeGenWriteBarrier((&___Instance_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SETARRAYITEMINSTRUCTION_TADF1CC4120E6E891C701BDC2C9445B8D7A639478_H
#ifndef STRINGSWITCHINSTRUCTION_T9395F34F26292304C90F5CF737E47858AF046C98_H
#define STRINGSWITCHINSTRUCTION_T9395F34F26292304C90F5CF737E47858AF046C98_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.StringSwitchInstruction
struct  StringSwitchInstruction_t9395F34F26292304C90F5CF737E47858AF046C98  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> System.Linq.Expressions.Interpreter.StringSwitchInstruction::_cases
	Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB * ____cases_0;
	// System.Runtime.CompilerServices.StrongBox`1<System.Int32> System.Linq.Expressions.Interpreter.StringSwitchInstruction::_nullCase
	StrongBox_1_tF235ABC61FF5FFF748E7FA114FC17E4192B954CF * ____nullCase_1;

public:
	inline static int32_t get_offset_of__cases_0() { return static_cast<int32_t>(offsetof(StringSwitchInstruction_t9395F34F26292304C90F5CF737E47858AF046C98, ____cases_0)); }
	inline Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB * get__cases_0() const { return ____cases_0; }
	inline Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB ** get_address_of__cases_0() { return &____cases_0; }
	inline void set__cases_0(Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB * value)
	{
		____cases_0 = value;
		Il2CppCodeGenWriteBarrier((&____cases_0), value);
	}

	inline static int32_t get_offset_of__nullCase_1() { return static_cast<int32_t>(offsetof(StringSwitchInstruction_t9395F34F26292304C90F5CF737E47858AF046C98, ____nullCase_1)); }
	inline StrongBox_1_tF235ABC61FF5FFF748E7FA114FC17E4192B954CF * get__nullCase_1() const { return ____nullCase_1; }
	inline StrongBox_1_tF235ABC61FF5FFF748E7FA114FC17E4192B954CF ** get_address_of__nullCase_1() { return &____nullCase_1; }
	inline void set__nullCase_1(StrongBox_1_tF235ABC61FF5FFF748E7FA114FC17E4192B954CF * value)
	{
		____nullCase_1 = value;
		Il2CppCodeGenWriteBarrier((&____nullCase_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STRINGSWITCHINSTRUCTION_T9395F34F26292304C90F5CF737E47858AF046C98_H
#ifndef THROWINSTRUCTION_TEE229813AC045E116B79F3727238A0DAA6640DE8_H
#define THROWINSTRUCTION_TEE229813AC045E116B79F3727238A0DAA6640DE8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ThrowInstruction
struct  ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8  : public Instruction_t235F1D5246CE88164576679572E0E858988436C3
{
public:
	// System.Boolean System.Linq.Expressions.Interpreter.ThrowInstruction::_hasResult
	bool ____hasResult_5;
	// System.Boolean System.Linq.Expressions.Interpreter.ThrowInstruction::_rethrow
	bool ____rethrow_6;

public:
	inline static int32_t get_offset_of__hasResult_5() { return static_cast<int32_t>(offsetof(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8, ____hasResult_5)); }
	inline bool get__hasResult_5() const { return ____hasResult_5; }
	inline bool* get_address_of__hasResult_5() { return &____hasResult_5; }
	inline void set__hasResult_5(bool value)
	{
		____hasResult_5 = value;
	}

	inline static int32_t get_offset_of__rethrow_6() { return static_cast<int32_t>(offsetof(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8, ____rethrow_6)); }
	inline bool get__rethrow_6() const { return ____rethrow_6; }
	inline bool* get_address_of__rethrow_6() { return &____rethrow_6; }
	inline void set__rethrow_6(bool value)
	{
		____rethrow_6 = value;
	}
};

struct ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.ThrowInstruction System.Linq.Expressions.Interpreter.ThrowInstruction::Throw
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * ___Throw_0;
	// System.Linq.Expressions.Interpreter.ThrowInstruction System.Linq.Expressions.Interpreter.ThrowInstruction::VoidThrow
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * ___VoidThrow_1;
	// System.Linq.Expressions.Interpreter.ThrowInstruction System.Linq.Expressions.Interpreter.ThrowInstruction::Rethrow
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * ___Rethrow_2;
	// System.Linq.Expressions.Interpreter.ThrowInstruction System.Linq.Expressions.Interpreter.ThrowInstruction::VoidRethrow
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * ___VoidRethrow_3;
	// System.Reflection.ConstructorInfo System.Linq.Expressions.Interpreter.ThrowInstruction::_runtimeWrappedExceptionCtor
	ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF * ____runtimeWrappedExceptionCtor_4;

public:
	inline static int32_t get_offset_of_Throw_0() { return static_cast<int32_t>(offsetof(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields, ___Throw_0)); }
	inline ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * get_Throw_0() const { return ___Throw_0; }
	inline ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 ** get_address_of_Throw_0() { return &___Throw_0; }
	inline void set_Throw_0(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * value)
	{
		___Throw_0 = value;
		Il2CppCodeGenWriteBarrier((&___Throw_0), value);
	}

	inline static int32_t get_offset_of_VoidThrow_1() { return static_cast<int32_t>(offsetof(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields, ___VoidThrow_1)); }
	inline ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * get_VoidThrow_1() const { return ___VoidThrow_1; }
	inline ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 ** get_address_of_VoidThrow_1() { return &___VoidThrow_1; }
	inline void set_VoidThrow_1(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * value)
	{
		___VoidThrow_1 = value;
		Il2CppCodeGenWriteBarrier((&___VoidThrow_1), value);
	}

	inline static int32_t get_offset_of_Rethrow_2() { return static_cast<int32_t>(offsetof(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields, ___Rethrow_2)); }
	inline ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * get_Rethrow_2() const { return ___Rethrow_2; }
	inline ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 ** get_address_of_Rethrow_2() { return &___Rethrow_2; }
	inline void set_Rethrow_2(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * value)
	{
		___Rethrow_2 = value;
		Il2CppCodeGenWriteBarrier((&___Rethrow_2), value);
	}

	inline static int32_t get_offset_of_VoidRethrow_3() { return static_cast<int32_t>(offsetof(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields, ___VoidRethrow_3)); }
	inline ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * get_VoidRethrow_3() const { return ___VoidRethrow_3; }
	inline ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 ** get_address_of_VoidRethrow_3() { return &___VoidRethrow_3; }
	inline void set_VoidRethrow_3(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8 * value)
	{
		___VoidRethrow_3 = value;
		Il2CppCodeGenWriteBarrier((&___VoidRethrow_3), value);
	}

	inline static int32_t get_offset_of__runtimeWrappedExceptionCtor_4() { return static_cast<int32_t>(offsetof(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields, ____runtimeWrappedExceptionCtor_4)); }
	inline ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF * get__runtimeWrappedExceptionCtor_4() const { return ____runtimeWrappedExceptionCtor_4; }
	inline ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF ** get_address_of__runtimeWrappedExceptionCtor_4() { return &____runtimeWrappedExceptionCtor_4; }
	inline void set__runtimeWrappedExceptionCtor_4(ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF * value)
	{
		____runtimeWrappedExceptionCtor_4 = value;
		Il2CppCodeGenWriteBarrier((&____runtimeWrappedExceptionCtor_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // THROWINSTRUCTION_TEE229813AC045E116B79F3727238A0DAA6640DE8_H
#ifndef ANDBOOLEAN_TA6C3EB9E6258DC339B63AF2E853B98EB91A3A619_H
#define ANDBOOLEAN_TA6C3EB9E6258DC339B63AF2E853B98EB91A3A619_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AndInstruction_AndBoolean
struct  AndBoolean_tA6C3EB9E6258DC339B63AF2E853B98EB91A3A619  : public AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANDBOOLEAN_TA6C3EB9E6258DC339B63AF2E853B98EB91A3A619_H
#ifndef ANDBYTE_TB1A3168B9DCD8833D183E93417D48B64DA04FA59_H
#define ANDBYTE_TB1A3168B9DCD8833D183E93417D48B64DA04FA59_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AndInstruction_AndByte
struct  AndByte_tB1A3168B9DCD8833D183E93417D48B64DA04FA59  : public AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANDBYTE_TB1A3168B9DCD8833D183E93417D48B64DA04FA59_H
#ifndef ANDINT16_TB083C7B2794A9EE02094D1605F36A5DFFE7EBC39_H
#define ANDINT16_TB083C7B2794A9EE02094D1605F36A5DFFE7EBC39_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AndInstruction_AndInt16
struct  AndInt16_tB083C7B2794A9EE02094D1605F36A5DFFE7EBC39  : public AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANDINT16_TB083C7B2794A9EE02094D1605F36A5DFFE7EBC39_H
#ifndef ANDINT32_T0BF97D49FEF345A9C5D5ED9563A3E24BACFB5D56_H
#define ANDINT32_T0BF97D49FEF345A9C5D5ED9563A3E24BACFB5D56_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AndInstruction_AndInt32
struct  AndInt32_t0BF97D49FEF345A9C5D5ED9563A3E24BACFB5D56  : public AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANDINT32_T0BF97D49FEF345A9C5D5ED9563A3E24BACFB5D56_H
#ifndef ANDINT64_T055A1551005CF0DF2002020E01C698ADD3E7E7EE_H
#define ANDINT64_T055A1551005CF0DF2002020E01C698ADD3E7E7EE_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AndInstruction_AndInt64
struct  AndInt64_t055A1551005CF0DF2002020E01C698ADD3E7E7EE  : public AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANDINT64_T055A1551005CF0DF2002020E01C698ADD3E7E7EE_H
#ifndef ANDUINT16_T825C7B42AD55378841AD0D87C14E2DA4474D5016_H
#define ANDUINT16_T825C7B42AD55378841AD0D87C14E2DA4474D5016_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AndInstruction_AndUInt16
struct  AndUInt16_t825C7B42AD55378841AD0D87C14E2DA4474D5016  : public AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANDUINT16_T825C7B42AD55378841AD0D87C14E2DA4474D5016_H
#ifndef ANDUINT32_T72CB8EBA14A1F65FA0501D1BE29B2B715EF46ACF_H
#define ANDUINT32_T72CB8EBA14A1F65FA0501D1BE29B2B715EF46ACF_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AndInstruction_AndUInt32
struct  AndUInt32_t72CB8EBA14A1F65FA0501D1BE29B2B715EF46ACF  : public AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANDUINT32_T72CB8EBA14A1F65FA0501D1BE29B2B715EF46ACF_H
#ifndef ANDUINT64_TA4A8E43DA32F7475508EC262FA3BCEA84F3E56DC_H
#define ANDUINT64_TA4A8E43DA32F7475508EC262FA3BCEA84F3E56DC_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.AndInstruction_AndUInt64
struct  AndUInt64_tA4A8E43DA32F7475508EC262FA3BCEA84F3E56DC  : public AndInstruction_t2AD347F5F9FC2EA125D2B650F3D49B3D7CDE52AC
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANDUINT64_TA4A8E43DA32F7475508EC262FA3BCEA84F3E56DC_H
#ifndef BRANCHFALSEINSTRUCTION_TBCEFD036D44D8431140FC018715991383689C266_H
#define BRANCHFALSEINSTRUCTION_TBCEFD036D44D8431140FC018715991383689C266_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.BranchFalseInstruction
struct  BranchFalseInstruction_tBCEFD036D44D8431140FC018715991383689C266  : public OffsetInstruction_tC6482B97ABF5D496066EBCFB48B452115DF00063
{
public:

public:
};

struct BranchFalseInstruction_tBCEFD036D44D8431140FC018715991383689C266_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction[] System.Linq.Expressions.Interpreter.BranchFalseInstruction::s_cache
	InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756* ___s_cache_1;

public:
	inline static int32_t get_offset_of_s_cache_1() { return static_cast<int32_t>(offsetof(BranchFalseInstruction_tBCEFD036D44D8431140FC018715991383689C266_StaticFields, ___s_cache_1)); }
	inline InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756* get_s_cache_1() const { return ___s_cache_1; }
	inline InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756** get_address_of_s_cache_1() { return &___s_cache_1; }
	inline void set_s_cache_1(InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756* value)
	{
		___s_cache_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_cache_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BRANCHFALSEINSTRUCTION_TBCEFD036D44D8431140FC018715991383689C266_H
#ifndef BRANCHINSTRUCTION_T87613F18047B07A63B644BEF6537677D525A1149_H
#define BRANCHINSTRUCTION_T87613F18047B07A63B644BEF6537677D525A1149_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.BranchInstruction
struct  BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149  : public OffsetInstruction_tC6482B97ABF5D496066EBCFB48B452115DF00063
{
public:
	// System.Boolean System.Linq.Expressions.Interpreter.BranchInstruction::_hasResult
	bool ____hasResult_2;
	// System.Boolean System.Linq.Expressions.Interpreter.BranchInstruction::_hasValue
	bool ____hasValue_3;

public:
	inline static int32_t get_offset_of__hasResult_2() { return static_cast<int32_t>(offsetof(BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149, ____hasResult_2)); }
	inline bool get__hasResult_2() const { return ____hasResult_2; }
	inline bool* get_address_of__hasResult_2() { return &____hasResult_2; }
	inline void set__hasResult_2(bool value)
	{
		____hasResult_2 = value;
	}

	inline static int32_t get_offset_of__hasValue_3() { return static_cast<int32_t>(offsetof(BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149, ____hasValue_3)); }
	inline bool get__hasValue_3() const { return ____hasValue_3; }
	inline bool* get_address_of__hasValue_3() { return &____hasValue_3; }
	inline void set__hasValue_3(bool value)
	{
		____hasValue_3 = value;
	}
};

struct BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction[][][] System.Linq.Expressions.Interpreter.BranchInstruction::s_caches
	InstructionU5BU5DU5BU5DU5BU5D_tC4888457FC83FAC515EA54CF8CBA6788F5210CE8* ___s_caches_1;

public:
	inline static int32_t get_offset_of_s_caches_1() { return static_cast<int32_t>(offsetof(BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149_StaticFields, ___s_caches_1)); }
	inline InstructionU5BU5DU5BU5DU5BU5D_tC4888457FC83FAC515EA54CF8CBA6788F5210CE8* get_s_caches_1() const { return ___s_caches_1; }
	inline InstructionU5BU5DU5BU5DU5BU5D_tC4888457FC83FAC515EA54CF8CBA6788F5210CE8** get_address_of_s_caches_1() { return &___s_caches_1; }
	inline void set_s_caches_1(InstructionU5BU5DU5BU5DU5BU5D_tC4888457FC83FAC515EA54CF8CBA6788F5210CE8* value)
	{
		___s_caches_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_caches_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BRANCHINSTRUCTION_T87613F18047B07A63B644BEF6537677D525A1149_H
#ifndef BRANCHTRUEINSTRUCTION_TB3E3FA83B686AE558530592545AB3ED5C75801E7_H
#define BRANCHTRUEINSTRUCTION_TB3E3FA83B686AE558530592545AB3ED5C75801E7_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.BranchTrueInstruction
struct  BranchTrueInstruction_tB3E3FA83B686AE558530592545AB3ED5C75801E7  : public OffsetInstruction_tC6482B97ABF5D496066EBCFB48B452115DF00063
{
public:

public:
};

struct BranchTrueInstruction_tB3E3FA83B686AE558530592545AB3ED5C75801E7_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction[] System.Linq.Expressions.Interpreter.BranchTrueInstruction::s_cache
	InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756* ___s_cache_1;

public:
	inline static int32_t get_offset_of_s_cache_1() { return static_cast<int32_t>(offsetof(BranchTrueInstruction_tB3E3FA83B686AE558530592545AB3ED5C75801E7_StaticFields, ___s_cache_1)); }
	inline InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756* get_s_cache_1() const { return ___s_cache_1; }
	inline InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756** get_address_of_s_cache_1() { return &___s_cache_1; }
	inline void set_s_cache_1(InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756* value)
	{
		___s_cache_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_cache_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BRANCHTRUEINSTRUCTION_TB3E3FA83B686AE558530592545AB3ED5C75801E7_H
#ifndef COALESCINGBRANCHINSTRUCTION_T1A16855A8392EF113D1F9840737F4C79C0DE2D8B_H
#define COALESCINGBRANCHINSTRUCTION_T1A16855A8392EF113D1F9840737F4C79C0DE2D8B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.CoalescingBranchInstruction
struct  CoalescingBranchInstruction_t1A16855A8392EF113D1F9840737F4C79C0DE2D8B  : public OffsetInstruction_tC6482B97ABF5D496066EBCFB48B452115DF00063
{
public:

public:
};

struct CoalescingBranchInstruction_t1A16855A8392EF113D1F9840737F4C79C0DE2D8B_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.Instruction[] System.Linq.Expressions.Interpreter.CoalescingBranchInstruction::s_cache
	InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756* ___s_cache_1;

public:
	inline static int32_t get_offset_of_s_cache_1() { return static_cast<int32_t>(offsetof(CoalescingBranchInstruction_t1A16855A8392EF113D1F9840737F4C79C0DE2D8B_StaticFields, ___s_cache_1)); }
	inline InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756* get_s_cache_1() const { return ___s_cache_1; }
	inline InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756** get_address_of_s_cache_1() { return &___s_cache_1; }
	inline void set_s_cache_1(InstructionU5BU5D_t03DD0A731543939153F0811D455A009486115756* value)
	{
		___s_cache_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_cache_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COALESCINGBRANCHINSTRUCTION_T1A16855A8392EF113D1F9840737F4C79C0DE2D8B_H
#ifndef DECREMENTDOUBLE_TDF8E382CD2029C93FBE6F0FF8FEDB5F40C794E18_H
#define DECREMENTDOUBLE_TDF8E382CD2029C93FBE6F0FF8FEDB5F40C794E18_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DecrementInstruction_DecrementDouble
struct  DecrementDouble_tDF8E382CD2029C93FBE6F0FF8FEDB5F40C794E18  : public DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DECREMENTDOUBLE_TDF8E382CD2029C93FBE6F0FF8FEDB5F40C794E18_H
#ifndef DECREMENTINT16_T685FC84C1301DAC5D22E9105078C1A30336010B3_H
#define DECREMENTINT16_T685FC84C1301DAC5D22E9105078C1A30336010B3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DecrementInstruction_DecrementInt16
struct  DecrementInt16_t685FC84C1301DAC5D22E9105078C1A30336010B3  : public DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DECREMENTINT16_T685FC84C1301DAC5D22E9105078C1A30336010B3_H
#ifndef DECREMENTINT32_TC15CD8CDA8852F11FE5B2129D80E1FE2C8975771_H
#define DECREMENTINT32_TC15CD8CDA8852F11FE5B2129D80E1FE2C8975771_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DecrementInstruction_DecrementInt32
struct  DecrementInt32_tC15CD8CDA8852F11FE5B2129D80E1FE2C8975771  : public DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DECREMENTINT32_TC15CD8CDA8852F11FE5B2129D80E1FE2C8975771_H
#ifndef DECREMENTINT64_TEE2942340C37FF3F0140491C727EECC1B47D5EE8_H
#define DECREMENTINT64_TEE2942340C37FF3F0140491C727EECC1B47D5EE8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DecrementInstruction_DecrementInt64
struct  DecrementInt64_tEE2942340C37FF3F0140491C727EECC1B47D5EE8  : public DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DECREMENTINT64_TEE2942340C37FF3F0140491C727EECC1B47D5EE8_H
#ifndef DECREMENTSINGLE_T206C0302963E29C25D71BA9B69DAF5E5ACC3ADF3_H
#define DECREMENTSINGLE_T206C0302963E29C25D71BA9B69DAF5E5ACC3ADF3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DecrementInstruction_DecrementSingle
struct  DecrementSingle_t206C0302963E29C25D71BA9B69DAF5E5ACC3ADF3  : public DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DECREMENTSINGLE_T206C0302963E29C25D71BA9B69DAF5E5ACC3ADF3_H
#ifndef DECREMENTUINT16_T22E7EEE1C1F18B6C48B7A5DF7AB7977BEB711F76_H
#define DECREMENTUINT16_T22E7EEE1C1F18B6C48B7A5DF7AB7977BEB711F76_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DecrementInstruction_DecrementUInt16
struct  DecrementUInt16_t22E7EEE1C1F18B6C48B7A5DF7AB7977BEB711F76  : public DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DECREMENTUINT16_T22E7EEE1C1F18B6C48B7A5DF7AB7977BEB711F76_H
#ifndef DECREMENTUINT32_T348386B760B938D94B5B2ED1EDAEFE2E5609DA8B_H
#define DECREMENTUINT32_T348386B760B938D94B5B2ED1EDAEFE2E5609DA8B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DecrementInstruction_DecrementUInt32
struct  DecrementUInt32_t348386B760B938D94B5B2ED1EDAEFE2E5609DA8B  : public DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DECREMENTUINT32_T348386B760B938D94B5B2ED1EDAEFE2E5609DA8B_H
#ifndef DECREMENTUINT64_TF39E462999338D503EE7ED326C09F080BEB8A4C5_H
#define DECREMENTUINT64_TF39E462999338D503EE7ED326C09F080BEB8A4C5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DecrementInstruction_DecrementUInt64
struct  DecrementUInt64_tF39E462999338D503EE7ED326C09F080BEB8A4C5  : public DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DECREMENTUINT64_TF39E462999338D503EE7ED326C09F080BEB8A4C5_H
#ifndef DIVDOUBLE_T8EF9EF21001315C3F8EBEC142DC2CDFAAAE006B5_H
#define DIVDOUBLE_T8EF9EF21001315C3F8EBEC142DC2CDFAAAE006B5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DivInstruction_DivDouble
struct  DivDouble_t8EF9EF21001315C3F8EBEC142DC2CDFAAAE006B5  : public DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DIVDOUBLE_T8EF9EF21001315C3F8EBEC142DC2CDFAAAE006B5_H
#ifndef DIVINT16_T33BFEB4C9D214D033F813FF7B6564C9DE6593B8B_H
#define DIVINT16_T33BFEB4C9D214D033F813FF7B6564C9DE6593B8B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DivInstruction_DivInt16
struct  DivInt16_t33BFEB4C9D214D033F813FF7B6564C9DE6593B8B  : public DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DIVINT16_T33BFEB4C9D214D033F813FF7B6564C9DE6593B8B_H
#ifndef DIVINT32_TCF776B1E1A65A2825D507A702081EFB9778B430B_H
#define DIVINT32_TCF776B1E1A65A2825D507A702081EFB9778B430B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DivInstruction_DivInt32
struct  DivInt32_tCF776B1E1A65A2825D507A702081EFB9778B430B  : public DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DIVINT32_TCF776B1E1A65A2825D507A702081EFB9778B430B_H
#ifndef DIVINT64_TF3A9BC3DC23720401346E79B49810B240E4C202B_H
#define DIVINT64_TF3A9BC3DC23720401346E79B49810B240E4C202B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DivInstruction_DivInt64
struct  DivInt64_tF3A9BC3DC23720401346E79B49810B240E4C202B  : public DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DIVINT64_TF3A9BC3DC23720401346E79B49810B240E4C202B_H
#ifndef DIVSINGLE_T55008BE702FA8BB0A6154722DC4C4A1865BA5873_H
#define DIVSINGLE_T55008BE702FA8BB0A6154722DC4C4A1865BA5873_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DivInstruction_DivSingle
struct  DivSingle_t55008BE702FA8BB0A6154722DC4C4A1865BA5873  : public DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DIVSINGLE_T55008BE702FA8BB0A6154722DC4C4A1865BA5873_H
#ifndef DIVUINT16_T427CA6DB168963E37C3245AD17AE26C2AC0065B7_H
#define DIVUINT16_T427CA6DB168963E37C3245AD17AE26C2AC0065B7_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DivInstruction_DivUInt16
struct  DivUInt16_t427CA6DB168963E37C3245AD17AE26C2AC0065B7  : public DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DIVUINT16_T427CA6DB168963E37C3245AD17AE26C2AC0065B7_H
#ifndef DIVUINT32_TABFBB77D7527C4373B7BA2BC0D81FF3541787EA1_H
#define DIVUINT32_TABFBB77D7527C4373B7BA2BC0D81FF3541787EA1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DivInstruction_DivUInt32
struct  DivUInt32_tABFBB77D7527C4373B7BA2BC0D81FF3541787EA1  : public DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DIVUINT32_TABFBB77D7527C4373B7BA2BC0D81FF3541787EA1_H
#ifndef DIVUINT64_T7083EB7CFFCA814C2CA18B8E4F40900D0C645279_H
#define DIVUINT64_T7083EB7CFFCA814C2CA18B8E4F40900D0C645279_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.DivInstruction_DivUInt64
struct  DivUInt64_t7083EB7CFFCA814C2CA18B8E4F40900D0C645279  : public DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DIVUINT64_T7083EB7CFFCA814C2CA18B8E4F40900D0C645279_H
#ifndef ENTERFAULTINSTRUCTION_TE9885EC49B1451211A63A8404D38D8133818EDD2_H
#define ENTERFAULTINSTRUCTION_TE9885EC49B1451211A63A8404D38D8133818EDD2_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EnterFaultInstruction
struct  EnterFaultInstruction_tE9885EC49B1451211A63A8404D38D8133818EDD2  : public IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E
{
public:

public:
};

struct EnterFaultInstruction_tE9885EC49B1451211A63A8404D38D8133818EDD2_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.EnterFaultInstruction[] System.Linq.Expressions.Interpreter.EnterFaultInstruction::s_cache
	EnterFaultInstructionU5BU5D_tC830C8A5F8062774F0051C0CA3F885CC8699D441* ___s_cache_1;

public:
	inline static int32_t get_offset_of_s_cache_1() { return static_cast<int32_t>(offsetof(EnterFaultInstruction_tE9885EC49B1451211A63A8404D38D8133818EDD2_StaticFields, ___s_cache_1)); }
	inline EnterFaultInstructionU5BU5D_tC830C8A5F8062774F0051C0CA3F885CC8699D441* get_s_cache_1() const { return ___s_cache_1; }
	inline EnterFaultInstructionU5BU5D_tC830C8A5F8062774F0051C0CA3F885CC8699D441** get_address_of_s_cache_1() { return &___s_cache_1; }
	inline void set_s_cache_1(EnterFaultInstructionU5BU5D_tC830C8A5F8062774F0051C0CA3F885CC8699D441* value)
	{
		___s_cache_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_cache_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENTERFAULTINSTRUCTION_TE9885EC49B1451211A63A8404D38D8133818EDD2_H
#ifndef ENTERFINALLYINSTRUCTION_T680113D68611CB2F0360244809742BB577D027F3_H
#define ENTERFINALLYINSTRUCTION_T680113D68611CB2F0360244809742BB577D027F3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EnterFinallyInstruction
struct  EnterFinallyInstruction_t680113D68611CB2F0360244809742BB577D027F3  : public IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E
{
public:

public:
};

struct EnterFinallyInstruction_t680113D68611CB2F0360244809742BB577D027F3_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.EnterFinallyInstruction[] System.Linq.Expressions.Interpreter.EnterFinallyInstruction::s_cache
	EnterFinallyInstructionU5BU5D_t634E9112AFFB398E4426B95DCADBC97C41C2897C* ___s_cache_1;

public:
	inline static int32_t get_offset_of_s_cache_1() { return static_cast<int32_t>(offsetof(EnterFinallyInstruction_t680113D68611CB2F0360244809742BB577D027F3_StaticFields, ___s_cache_1)); }
	inline EnterFinallyInstructionU5BU5D_t634E9112AFFB398E4426B95DCADBC97C41C2897C* get_s_cache_1() const { return ___s_cache_1; }
	inline EnterFinallyInstructionU5BU5D_t634E9112AFFB398E4426B95DCADBC97C41C2897C** get_address_of_s_cache_1() { return &___s_cache_1; }
	inline void set_s_cache_1(EnterFinallyInstructionU5BU5D_t634E9112AFFB398E4426B95DCADBC97C41C2897C* value)
	{
		___s_cache_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_cache_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENTERFINALLYINSTRUCTION_T680113D68611CB2F0360244809742BB577D027F3_H
#ifndef ENTERTRYCATCHFINALLYINSTRUCTION_T812A2C0330D60FE93D57B23F588DBF4709776832_H
#define ENTERTRYCATCHFINALLYINSTRUCTION_T812A2C0330D60FE93D57B23F588DBF4709776832_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EnterTryCatchFinallyInstruction
struct  EnterTryCatchFinallyInstruction_t812A2C0330D60FE93D57B23F588DBF4709776832  : public IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E
{
public:
	// System.Boolean System.Linq.Expressions.Interpreter.EnterTryCatchFinallyInstruction::_hasFinally
	bool ____hasFinally_1;
	// System.Linq.Expressions.Interpreter.TryCatchFinallyHandler System.Linq.Expressions.Interpreter.EnterTryCatchFinallyInstruction::_tryHandler
	TryCatchFinallyHandler_t7AB1E0FF1C486495BF0E0EEDD327548799F1D7D8 * ____tryHandler_2;

public:
	inline static int32_t get_offset_of__hasFinally_1() { return static_cast<int32_t>(offsetof(EnterTryCatchFinallyInstruction_t812A2C0330D60FE93D57B23F588DBF4709776832, ____hasFinally_1)); }
	inline bool get__hasFinally_1() const { return ____hasFinally_1; }
	inline bool* get_address_of__hasFinally_1() { return &____hasFinally_1; }
	inline void set__hasFinally_1(bool value)
	{
		____hasFinally_1 = value;
	}

	inline static int32_t get_offset_of__tryHandler_2() { return static_cast<int32_t>(offsetof(EnterTryCatchFinallyInstruction_t812A2C0330D60FE93D57B23F588DBF4709776832, ____tryHandler_2)); }
	inline TryCatchFinallyHandler_t7AB1E0FF1C486495BF0E0EEDD327548799F1D7D8 * get__tryHandler_2() const { return ____tryHandler_2; }
	inline TryCatchFinallyHandler_t7AB1E0FF1C486495BF0E0EEDD327548799F1D7D8 ** get_address_of__tryHandler_2() { return &____tryHandler_2; }
	inline void set__tryHandler_2(TryCatchFinallyHandler_t7AB1E0FF1C486495BF0E0EEDD327548799F1D7D8 * value)
	{
		____tryHandler_2 = value;
		Il2CppCodeGenWriteBarrier((&____tryHandler_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENTERTRYCATCHFINALLYINSTRUCTION_T812A2C0330D60FE93D57B23F588DBF4709776832_H
#ifndef ENTERTRYFAULTINSTRUCTION_T97D7427906E383FA3F14CDD060DA8B35E5B553DE_H
#define ENTERTRYFAULTINSTRUCTION_T97D7427906E383FA3F14CDD060DA8B35E5B553DE_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EnterTryFaultInstruction
struct  EnterTryFaultInstruction_t97D7427906E383FA3F14CDD060DA8B35E5B553DE  : public IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E
{
public:
	// System.Linq.Expressions.Interpreter.TryFaultHandler System.Linq.Expressions.Interpreter.EnterTryFaultInstruction::_tryHandler
	TryFaultHandler_t3F2F0A73BFC198B9142027A7B98F7A29FC6CDE13 * ____tryHandler_1;

public:
	inline static int32_t get_offset_of__tryHandler_1() { return static_cast<int32_t>(offsetof(EnterTryFaultInstruction_t97D7427906E383FA3F14CDD060DA8B35E5B553DE, ____tryHandler_1)); }
	inline TryFaultHandler_t3F2F0A73BFC198B9142027A7B98F7A29FC6CDE13 * get__tryHandler_1() const { return ____tryHandler_1; }
	inline TryFaultHandler_t3F2F0A73BFC198B9142027A7B98F7A29FC6CDE13 ** get_address_of__tryHandler_1() { return &____tryHandler_1; }
	inline void set__tryHandler_1(TryFaultHandler_t3F2F0A73BFC198B9142027A7B98F7A29FC6CDE13 * value)
	{
		____tryHandler_1 = value;
		Il2CppCodeGenWriteBarrier((&____tryHandler_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENTERTRYFAULTINSTRUCTION_T97D7427906E383FA3F14CDD060DA8B35E5B553DE_H
#ifndef EQUALBOOLEAN_TE4F1D48A660020E715A59756C4471130AF37E621_H
#define EQUALBOOLEAN_TE4F1D48A660020E715A59756C4471130AF37E621_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualBoolean
struct  EqualBoolean_tE4F1D48A660020E715A59756C4471130AF37E621  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALBOOLEAN_TE4F1D48A660020E715A59756C4471130AF37E621_H
#ifndef EQUALBOOLEANLIFTEDTONULL_T9E98C34347361F37D546E20F7308D66947AF348C_H
#define EQUALBOOLEANLIFTEDTONULL_T9E98C34347361F37D546E20F7308D66947AF348C_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualBooleanLiftedToNull
struct  EqualBooleanLiftedToNull_t9E98C34347361F37D546E20F7308D66947AF348C  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALBOOLEANLIFTEDTONULL_T9E98C34347361F37D546E20F7308D66947AF348C_H
#ifndef EQUALBYTE_T49CD77E9BC018FA9826BF0DE8F827CA711739896_H
#define EQUALBYTE_T49CD77E9BC018FA9826BF0DE8F827CA711739896_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualByte
struct  EqualByte_t49CD77E9BC018FA9826BF0DE8F827CA711739896  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALBYTE_T49CD77E9BC018FA9826BF0DE8F827CA711739896_H
#ifndef EQUALBYTELIFTEDTONULL_T47FF7CEC1BC44891A4D1E884EEC21C20D409ABCD_H
#define EQUALBYTELIFTEDTONULL_T47FF7CEC1BC44891A4D1E884EEC21C20D409ABCD_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualByteLiftedToNull
struct  EqualByteLiftedToNull_t47FF7CEC1BC44891A4D1E884EEC21C20D409ABCD  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALBYTELIFTEDTONULL_T47FF7CEC1BC44891A4D1E884EEC21C20D409ABCD_H
#ifndef EQUALCHAR_TAAF73D00A35D189A6F08213F31FDBAF27694432B_H
#define EQUALCHAR_TAAF73D00A35D189A6F08213F31FDBAF27694432B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualChar
struct  EqualChar_tAAF73D00A35D189A6F08213F31FDBAF27694432B  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALCHAR_TAAF73D00A35D189A6F08213F31FDBAF27694432B_H
#ifndef EQUALCHARLIFTEDTONULL_T03FBA23BD1889A35FF49804C8B8670CD2572DAAC_H
#define EQUALCHARLIFTEDTONULL_T03FBA23BD1889A35FF49804C8B8670CD2572DAAC_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualCharLiftedToNull
struct  EqualCharLiftedToNull_t03FBA23BD1889A35FF49804C8B8670CD2572DAAC  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALCHARLIFTEDTONULL_T03FBA23BD1889A35FF49804C8B8670CD2572DAAC_H
#ifndef EQUALDOUBLE_T6EBD63109F85BAC4338108D8C65BD797571BC7C7_H
#define EQUALDOUBLE_T6EBD63109F85BAC4338108D8C65BD797571BC7C7_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualDouble
struct  EqualDouble_t6EBD63109F85BAC4338108D8C65BD797571BC7C7  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALDOUBLE_T6EBD63109F85BAC4338108D8C65BD797571BC7C7_H
#ifndef EQUALDOUBLELIFTEDTONULL_T00F6BD6EEFA2059762CFBA753FCDDC6D032B9C55_H
#define EQUALDOUBLELIFTEDTONULL_T00F6BD6EEFA2059762CFBA753FCDDC6D032B9C55_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualDoubleLiftedToNull
struct  EqualDoubleLiftedToNull_t00F6BD6EEFA2059762CFBA753FCDDC6D032B9C55  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALDOUBLELIFTEDTONULL_T00F6BD6EEFA2059762CFBA753FCDDC6D032B9C55_H
#ifndef EQUALINT16_T2E33878A66976918FEEF7C9322919EF108C6DB92_H
#define EQUALINT16_T2E33878A66976918FEEF7C9322919EF108C6DB92_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualInt16
struct  EqualInt16_t2E33878A66976918FEEF7C9322919EF108C6DB92  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALINT16_T2E33878A66976918FEEF7C9322919EF108C6DB92_H
#ifndef EQUALINT16LIFTEDTONULL_T7D2B815940CCDD6E2ED463DF1FD195325CDF478A_H
#define EQUALINT16LIFTEDTONULL_T7D2B815940CCDD6E2ED463DF1FD195325CDF478A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualInt16LiftedToNull
struct  EqualInt16LiftedToNull_t7D2B815940CCDD6E2ED463DF1FD195325CDF478A  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALINT16LIFTEDTONULL_T7D2B815940CCDD6E2ED463DF1FD195325CDF478A_H
#ifndef EQUALINT32_T6928A128D08F0468B738E0A9C014B52F5DFA6A03_H
#define EQUALINT32_T6928A128D08F0468B738E0A9C014B52F5DFA6A03_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualInt32
struct  EqualInt32_t6928A128D08F0468B738E0A9C014B52F5DFA6A03  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALINT32_T6928A128D08F0468B738E0A9C014B52F5DFA6A03_H
#ifndef EQUALINT32LIFTEDTONULL_T997D977FEF539500D5492BB4D0DBC66E9050661F_H
#define EQUALINT32LIFTEDTONULL_T997D977FEF539500D5492BB4D0DBC66E9050661F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualInt32LiftedToNull
struct  EqualInt32LiftedToNull_t997D977FEF539500D5492BB4D0DBC66E9050661F  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALINT32LIFTEDTONULL_T997D977FEF539500D5492BB4D0DBC66E9050661F_H
#ifndef EQUALINT64_T71FD9B2283FEF4234597EAA48CF7D6C285D720BB_H
#define EQUALINT64_T71FD9B2283FEF4234597EAA48CF7D6C285D720BB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualInt64
struct  EqualInt64_t71FD9B2283FEF4234597EAA48CF7D6C285D720BB  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALINT64_T71FD9B2283FEF4234597EAA48CF7D6C285D720BB_H
#ifndef EQUALINT64LIFTEDTONULL_T38E8E36295D97C64606C84D5C9B5D5ECAB8881BD_H
#define EQUALINT64LIFTEDTONULL_T38E8E36295D97C64606C84D5C9B5D5ECAB8881BD_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualInt64LiftedToNull
struct  EqualInt64LiftedToNull_t38E8E36295D97C64606C84D5C9B5D5ECAB8881BD  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALINT64LIFTEDTONULL_T38E8E36295D97C64606C84D5C9B5D5ECAB8881BD_H
#ifndef EQUALREFERENCE_T5784DC95C8F544CB7B5626C39DF458B63BAD4988_H
#define EQUALREFERENCE_T5784DC95C8F544CB7B5626C39DF458B63BAD4988_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualReference
struct  EqualReference_t5784DC95C8F544CB7B5626C39DF458B63BAD4988  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALREFERENCE_T5784DC95C8F544CB7B5626C39DF458B63BAD4988_H
#ifndef EQUALSBYTE_TE71DE060A984D4BABA1110B8C379981A11A84CF2_H
#define EQUALSBYTE_TE71DE060A984D4BABA1110B8C379981A11A84CF2_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualSByte
struct  EqualSByte_tE71DE060A984D4BABA1110B8C379981A11A84CF2  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALSBYTE_TE71DE060A984D4BABA1110B8C379981A11A84CF2_H
#ifndef EQUALSBYTELIFTEDTONULL_T297075E2B24E34F0DAAE6C2494F353F7EF3D3777_H
#define EQUALSBYTELIFTEDTONULL_T297075E2B24E34F0DAAE6C2494F353F7EF3D3777_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualSByteLiftedToNull
struct  EqualSByteLiftedToNull_t297075E2B24E34F0DAAE6C2494F353F7EF3D3777  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALSBYTELIFTEDTONULL_T297075E2B24E34F0DAAE6C2494F353F7EF3D3777_H
#ifndef EQUALSINGLE_TA06CB396E70ADD7CB752237210691B6F51A05A57_H
#define EQUALSINGLE_TA06CB396E70ADD7CB752237210691B6F51A05A57_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualSingle
struct  EqualSingle_tA06CB396E70ADD7CB752237210691B6F51A05A57  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALSINGLE_TA06CB396E70ADD7CB752237210691B6F51A05A57_H
#ifndef EQUALSINGLELIFTEDTONULL_TC9885AA62E349C6EAE166F0631F020F1724D1B39_H
#define EQUALSINGLELIFTEDTONULL_TC9885AA62E349C6EAE166F0631F020F1724D1B39_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualSingleLiftedToNull
struct  EqualSingleLiftedToNull_tC9885AA62E349C6EAE166F0631F020F1724D1B39  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALSINGLELIFTEDTONULL_TC9885AA62E349C6EAE166F0631F020F1724D1B39_H
#ifndef EQUALUINT16_T69E374E2D9CB2547CAE3E4C6E0DA14D6718AFC2C_H
#define EQUALUINT16_T69E374E2D9CB2547CAE3E4C6E0DA14D6718AFC2C_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualUInt16
struct  EqualUInt16_t69E374E2D9CB2547CAE3E4C6E0DA14D6718AFC2C  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALUINT16_T69E374E2D9CB2547CAE3E4C6E0DA14D6718AFC2C_H
#ifndef EQUALUINT16LIFTEDTONULL_TF7AF9237412B0BC1AAF0E20C45538ECD7D9F562C_H
#define EQUALUINT16LIFTEDTONULL_TF7AF9237412B0BC1AAF0E20C45538ECD7D9F562C_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualUInt16LiftedToNull
struct  EqualUInt16LiftedToNull_tF7AF9237412B0BC1AAF0E20C45538ECD7D9F562C  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALUINT16LIFTEDTONULL_TF7AF9237412B0BC1AAF0E20C45538ECD7D9F562C_H
#ifndef EQUALUINT32_TA935140965CA9E077DDED610489BD03F209E7A92_H
#define EQUALUINT32_TA935140965CA9E077DDED610489BD03F209E7A92_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualUInt32
struct  EqualUInt32_tA935140965CA9E077DDED610489BD03F209E7A92  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALUINT32_TA935140965CA9E077DDED610489BD03F209E7A92_H
#ifndef EQUALUINT32LIFTEDTONULL_TDC3B6AC8ED6BBBAB01051A3A673FD2C0C5EBB8BC_H
#define EQUALUINT32LIFTEDTONULL_TDC3B6AC8ED6BBBAB01051A3A673FD2C0C5EBB8BC_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualUInt32LiftedToNull
struct  EqualUInt32LiftedToNull_tDC3B6AC8ED6BBBAB01051A3A673FD2C0C5EBB8BC  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALUINT32LIFTEDTONULL_TDC3B6AC8ED6BBBAB01051A3A673FD2C0C5EBB8BC_H
#ifndef EQUALUINT64_T5E7456016C1AB311639467C75F6D8C50C8A90B54_H
#define EQUALUINT64_T5E7456016C1AB311639467C75F6D8C50C8A90B54_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualUInt64
struct  EqualUInt64_t5E7456016C1AB311639467C75F6D8C50C8A90B54  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALUINT64_T5E7456016C1AB311639467C75F6D8C50C8A90B54_H
#ifndef EQUALUINT64LIFTEDTONULL_T1F3349D0E5FA97DB739B0002F7866662D92A92C2_H
#define EQUALUINT64LIFTEDTONULL_T1F3349D0E5FA97DB739B0002F7866662D92A92C2_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.EqualInstruction_EqualUInt64LiftedToNull
struct  EqualUInt64LiftedToNull_t1F3349D0E5FA97DB739B0002F7866662D92A92C2  : public EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALUINT64LIFTEDTONULL_T1F3349D0E5FA97DB739B0002F7866662D92A92C2_H
#ifndef EXCLUSIVEORBOOLEAN_TC234E95444AC0B93F97109462C6C801DD102E77C_H
#define EXCLUSIVEORBOOLEAN_TC234E95444AC0B93F97109462C6C801DD102E77C_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction_ExclusiveOrBoolean
struct  ExclusiveOrBoolean_tC234E95444AC0B93F97109462C6C801DD102E77C  : public ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORBOOLEAN_TC234E95444AC0B93F97109462C6C801DD102E77C_H
#ifndef EXCLUSIVEORBYTE_T0D98D60BFE7DBF0AB3512ADC48255075290564C4_H
#define EXCLUSIVEORBYTE_T0D98D60BFE7DBF0AB3512ADC48255075290564C4_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction_ExclusiveOrByte
struct  ExclusiveOrByte_t0D98D60BFE7DBF0AB3512ADC48255075290564C4  : public ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORBYTE_T0D98D60BFE7DBF0AB3512ADC48255075290564C4_H
#ifndef EXCLUSIVEORINT16_T699125E97671E3781715279BBD8AC75FCA9F9188_H
#define EXCLUSIVEORINT16_T699125E97671E3781715279BBD8AC75FCA9F9188_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction_ExclusiveOrInt16
struct  ExclusiveOrInt16_t699125E97671E3781715279BBD8AC75FCA9F9188  : public ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORINT16_T699125E97671E3781715279BBD8AC75FCA9F9188_H
#ifndef EXCLUSIVEORINT32_T4E5C6C5DDAF97096AD8CE0A64674FFC31DF4DCAA_H
#define EXCLUSIVEORINT32_T4E5C6C5DDAF97096AD8CE0A64674FFC31DF4DCAA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction_ExclusiveOrInt32
struct  ExclusiveOrInt32_t4E5C6C5DDAF97096AD8CE0A64674FFC31DF4DCAA  : public ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORINT32_T4E5C6C5DDAF97096AD8CE0A64674FFC31DF4DCAA_H
#ifndef EXCLUSIVEORINT64_TD157C18892783602CBF1CF35354F77B387DCE465_H
#define EXCLUSIVEORINT64_TD157C18892783602CBF1CF35354F77B387DCE465_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction_ExclusiveOrInt64
struct  ExclusiveOrInt64_tD157C18892783602CBF1CF35354F77B387DCE465  : public ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORINT64_TD157C18892783602CBF1CF35354F77B387DCE465_H
#ifndef EXCLUSIVEORSBYTE_T8250C02D10E6E7225200CB69B66ADA0494BF4F67_H
#define EXCLUSIVEORSBYTE_T8250C02D10E6E7225200CB69B66ADA0494BF4F67_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction_ExclusiveOrSByte
struct  ExclusiveOrSByte_t8250C02D10E6E7225200CB69B66ADA0494BF4F67  : public ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORSBYTE_T8250C02D10E6E7225200CB69B66ADA0494BF4F67_H
#ifndef EXCLUSIVEORUINT16_T16633E139C7C947E1CEA3D951E869BF36880BFDE_H
#define EXCLUSIVEORUINT16_T16633E139C7C947E1CEA3D951E869BF36880BFDE_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction_ExclusiveOrUInt16
struct  ExclusiveOrUInt16_t16633E139C7C947E1CEA3D951E869BF36880BFDE  : public ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORUINT16_T16633E139C7C947E1CEA3D951E869BF36880BFDE_H
#ifndef EXCLUSIVEORUINT32_T949A7AD98BBE1971B53DD718B0A8677B22B6013F_H
#define EXCLUSIVEORUINT32_T949A7AD98BBE1971B53DD718B0A8677B22B6013F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction_ExclusiveOrUInt32
struct  ExclusiveOrUInt32_t949A7AD98BBE1971B53DD718B0A8677B22B6013F  : public ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORUINT32_T949A7AD98BBE1971B53DD718B0A8677B22B6013F_H
#ifndef EXCLUSIVEORUINT64_T702A2B2F4F25815CB8818DD2DDE4FB499C9C4B5B_H
#define EXCLUSIVEORUINT64_T702A2B2F4F25815CB8818DD2DDE4FB499C9C4B5B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ExclusiveOrInstruction_ExclusiveOrUInt64
struct  ExclusiveOrUInt64_t702A2B2F4F25815CB8818DD2DDE4FB499C9C4B5B  : public ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCLUSIVEORUINT64_T702A2B2F4F25815CB8818DD2DDE4FB499C9C4B5B_H
#ifndef GOTOINSTRUCTION_T6FF004167D50525C4E5FF1C2E2B339E54F2392B3_H
#define GOTOINSTRUCTION_T6FF004167D50525C4E5FF1C2E2B339E54F2392B3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.GotoInstruction
struct  GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3  : public IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E
{
public:
	// System.Boolean System.Linq.Expressions.Interpreter.GotoInstruction::_hasResult
	bool ____hasResult_2;
	// System.Boolean System.Linq.Expressions.Interpreter.GotoInstruction::_hasValue
	bool ____hasValue_3;
	// System.Boolean System.Linq.Expressions.Interpreter.GotoInstruction::_labelTargetGetsValue
	bool ____labelTargetGetsValue_4;

public:
	inline static int32_t get_offset_of__hasResult_2() { return static_cast<int32_t>(offsetof(GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3, ____hasResult_2)); }
	inline bool get__hasResult_2() const { return ____hasResult_2; }
	inline bool* get_address_of__hasResult_2() { return &____hasResult_2; }
	inline void set__hasResult_2(bool value)
	{
		____hasResult_2 = value;
	}

	inline static int32_t get_offset_of__hasValue_3() { return static_cast<int32_t>(offsetof(GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3, ____hasValue_3)); }
	inline bool get__hasValue_3() const { return ____hasValue_3; }
	inline bool* get_address_of__hasValue_3() { return &____hasValue_3; }
	inline void set__hasValue_3(bool value)
	{
		____hasValue_3 = value;
	}

	inline static int32_t get_offset_of__labelTargetGetsValue_4() { return static_cast<int32_t>(offsetof(GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3, ____labelTargetGetsValue_4)); }
	inline bool get__labelTargetGetsValue_4() const { return ____labelTargetGetsValue_4; }
	inline bool* get_address_of__labelTargetGetsValue_4() { return &____labelTargetGetsValue_4; }
	inline void set__labelTargetGetsValue_4(bool value)
	{
		____labelTargetGetsValue_4 = value;
	}
};

struct GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.GotoInstruction[] System.Linq.Expressions.Interpreter.GotoInstruction::s_cache
	GotoInstructionU5BU5D_tF5B2267B62BBE20C5B087DF3F8598FB24713E4C7* ___s_cache_1;

public:
	inline static int32_t get_offset_of_s_cache_1() { return static_cast<int32_t>(offsetof(GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3_StaticFields, ___s_cache_1)); }
	inline GotoInstructionU5BU5D_tF5B2267B62BBE20C5B087DF3F8598FB24713E4C7* get_s_cache_1() const { return ___s_cache_1; }
	inline GotoInstructionU5BU5D_tF5B2267B62BBE20C5B087DF3F8598FB24713E4C7** get_address_of_s_cache_1() { return &___s_cache_1; }
	inline void set_s_cache_1(GotoInstructionU5BU5D_tF5B2267B62BBE20C5B087DF3F8598FB24713E4C7* value)
	{
		___s_cache_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_cache_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // GOTOINSTRUCTION_T6FF004167D50525C4E5FF1C2E2B339E54F2392B3_H
#ifndef LEAVEEXCEPTIONHANDLERINSTRUCTION_T920AF0C4284902BF42FB8D58B77A58C15F0694B4_H
#define LEAVEEXCEPTIONHANDLERINSTRUCTION_T920AF0C4284902BF42FB8D58B77A58C15F0694B4_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction
struct  LeaveExceptionHandlerInstruction_t920AF0C4284902BF42FB8D58B77A58C15F0694B4  : public IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E
{
public:
	// System.Boolean System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction::_hasValue
	bool ____hasValue_2;

public:
	inline static int32_t get_offset_of__hasValue_2() { return static_cast<int32_t>(offsetof(LeaveExceptionHandlerInstruction_t920AF0C4284902BF42FB8D58B77A58C15F0694B4, ____hasValue_2)); }
	inline bool get__hasValue_2() const { return ____hasValue_2; }
	inline bool* get_address_of__hasValue_2() { return &____hasValue_2; }
	inline void set__hasValue_2(bool value)
	{
		____hasValue_2 = value;
	}
};

struct LeaveExceptionHandlerInstruction_t920AF0C4284902BF42FB8D58B77A58C15F0694B4_StaticFields
{
public:
	// System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction[] System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction::s_cache
	LeaveExceptionHandlerInstructionU5BU5D_t0B7D9B28B5BFECB8F7334C9E01A23076CEF2184D* ___s_cache_1;

public:
	inline static int32_t get_offset_of_s_cache_1() { return static_cast<int32_t>(offsetof(LeaveExceptionHandlerInstruction_t920AF0C4284902BF42FB8D58B77A58C15F0694B4_StaticFields, ___s_cache_1)); }
	inline LeaveExceptionHandlerInstructionU5BU5D_t0B7D9B28B5BFECB8F7334C9E01A23076CEF2184D* get_s_cache_1() const { return ___s_cache_1; }
	inline LeaveExceptionHandlerInstructionU5BU5D_t0B7D9B28B5BFECB8F7334C9E01A23076CEF2184D** get_address_of_s_cache_1() { return &___s_cache_1; }
	inline void set_s_cache_1(LeaveExceptionHandlerInstructionU5BU5D_t0B7D9B28B5BFECB8F7334C9E01A23076CEF2184D* value)
	{
		___s_cache_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_cache_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LEAVEEXCEPTIONHANDLERINSTRUCTION_T920AF0C4284902BF42FB8D58B77A58C15F0694B4_H
#ifndef LOADFIELDINSTRUCTION_T4DD226BB90CBE3BA519C3F96969E004EC65FF3F0_H
#define LOADFIELDINSTRUCTION_T4DD226BB90CBE3BA519C3F96969E004EC65FF3F0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LoadFieldInstruction
struct  LoadFieldInstruction_t4DD226BB90CBE3BA519C3F96969E004EC65FF3F0  : public FieldInstruction_tE97586CE791336617EC1BA6284504911B7558E5A
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LOADFIELDINSTRUCTION_T4DD226BB90CBE3BA519C3F96969E004EC65FF3F0_H
#ifndef LOADSTATICFIELDINSTRUCTION_T3080FBE8B7BC9AA5EBE3181C18103F38397763D2_H
#define LOADSTATICFIELDINSTRUCTION_T3080FBE8B7BC9AA5EBE3181C18103F38397763D2_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.LoadStaticFieldInstruction
struct  LoadStaticFieldInstruction_t3080FBE8B7BC9AA5EBE3181C18103F38397763D2  : public FieldInstruction_tE97586CE791336617EC1BA6284504911B7558E5A
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LOADSTATICFIELDINSTRUCTION_T3080FBE8B7BC9AA5EBE3181C18103F38397763D2_H
#ifndef METHODINFOCALLINSTRUCTION_TD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8_H
#define METHODINFOCALLINSTRUCTION_TD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.MethodInfoCallInstruction
struct  MethodInfoCallInstruction_tD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8  : public CallInstruction_tE463EE38C397DCD089226727826DF7B48B5C0526
{
public:
	// System.Reflection.MethodInfo System.Linq.Expressions.Interpreter.MethodInfoCallInstruction::_target
	MethodInfo_t * ____target_0;
	// System.Int32 System.Linq.Expressions.Interpreter.MethodInfoCallInstruction::_argumentCount
	int32_t ____argumentCount_1;

public:
	inline static int32_t get_offset_of__target_0() { return static_cast<int32_t>(offsetof(MethodInfoCallInstruction_tD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8, ____target_0)); }
	inline MethodInfo_t * get__target_0() const { return ____target_0; }
	inline MethodInfo_t ** get_address_of__target_0() { return &____target_0; }
	inline void set__target_0(MethodInfo_t * value)
	{
		____target_0 = value;
		Il2CppCodeGenWriteBarrier((&____target_0), value);
	}

	inline static int32_t get_offset_of__argumentCount_1() { return static_cast<int32_t>(offsetof(MethodInfoCallInstruction_tD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8, ____argumentCount_1)); }
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
#endif // METHODINFOCALLINSTRUCTION_TD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8_H
#ifndef STOREFIELDINSTRUCTION_T4DEC9E11390102F8097F18519A45A58256E51188_H
#define STOREFIELDINSTRUCTION_T4DEC9E11390102F8097F18519A45A58256E51188_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.StoreFieldInstruction
struct  StoreFieldInstruction_t4DEC9E11390102F8097F18519A45A58256E51188  : public FieldInstruction_tE97586CE791336617EC1BA6284504911B7558E5A
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STOREFIELDINSTRUCTION_T4DEC9E11390102F8097F18519A45A58256E51188_H
#ifndef STORESTATICFIELDINSTRUCTION_T96E178E14E4460C9666EC4C650B3E24FD914D6AD_H
#define STORESTATICFIELDINSTRUCTION_T96E178E14E4460C9666EC4C650B3E24FD914D6AD_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.StoreStaticFieldInstruction
struct  StoreStaticFieldInstruction_t96E178E14E4460C9666EC4C650B3E24FD914D6AD  : public FieldInstruction_tE97586CE791336617EC1BA6284504911B7558E5A
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STORESTATICFIELDINSTRUCTION_T96E178E14E4460C9666EC4C650B3E24FD914D6AD_H
#ifndef BYREFMETHODINFOCALLINSTRUCTION_TCC12111BCAA3FBFBE597709AA68BEE9C07CFC33F_H
#define BYREFMETHODINFOCALLINSTRUCTION_TCC12111BCAA3FBFBE597709AA68BEE9C07CFC33F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Linq.Expressions.Interpreter.ByRefMethodInfoCallInstruction
struct  ByRefMethodInfoCallInstruction_tCC12111BCAA3FBFBE597709AA68BEE9C07CFC33F  : public MethodInfoCallInstruction_tD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8
{
public:
	// System.Linq.Expressions.Interpreter.ByRefUpdater[] System.Linq.Expressions.Interpreter.ByRefMethodInfoCallInstruction::_byrefArgs
	ByRefUpdaterU5BU5D_tDB1EB5674027EBA8F3752913C79D156F07CF97F7* ____byrefArgs_2;

public:
	inline static int32_t get_offset_of__byrefArgs_2() { return static_cast<int32_t>(offsetof(ByRefMethodInfoCallInstruction_tCC12111BCAA3FBFBE597709AA68BEE9C07CFC33F, ____byrefArgs_2)); }
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
#endif // BYREFMETHODINFOCALLINSTRUCTION_TCC12111BCAA3FBFBE597709AA68BEE9C07CFC33F_H





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2000 = { sizeof (AndInt16_tB083C7B2794A9EE02094D1605F36A5DFFE7EBC39), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2001 = { sizeof (AndInt32_t0BF97D49FEF345A9C5D5ED9563A3E24BACFB5D56), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2002 = { sizeof (AndInt64_t055A1551005CF0DF2002020E01C698ADD3E7E7EE), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2003 = { sizeof (AndByte_tB1A3168B9DCD8833D183E93417D48B64DA04FA59), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2004 = { sizeof (AndUInt16_t825C7B42AD55378841AD0D87C14E2DA4474D5016), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2005 = { sizeof (AndUInt32_t72CB8EBA14A1F65FA0501D1BE29B2B715EF46ACF), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2006 = { sizeof (AndUInt64_tA4A8E43DA32F7475508EC262FA3BCEA84F3E56DC), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2007 = { sizeof (AndBoolean_tA6C3EB9E6258DC339B63AF2E853B98EB91A3A619), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2008 = { sizeof (NewArrayInitInstruction_t5750C6A24A7B12F49C15D59B7C0ADBD5E523CC5F), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2008[2] = 
{
	NewArrayInitInstruction_t5750C6A24A7B12F49C15D59B7C0ADBD5E523CC5F::get_offset_of__elementType_0(),
	NewArrayInitInstruction_t5750C6A24A7B12F49C15D59B7C0ADBD5E523CC5F::get_offset_of__elementCount_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2009 = { sizeof (NewArrayInstruction_tBDA16F86FF6FB99F63B65FC558463C111AC61B05), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2009[1] = 
{
	NewArrayInstruction_tBDA16F86FF6FB99F63B65FC558463C111AC61B05::get_offset_of__elementType_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2010 = { sizeof (NewArrayBoundsInstruction_t5A4E6C08C0B27F679C1F780FD83B5CFB93AB50EF), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2010[2] = 
{
	NewArrayBoundsInstruction_t5A4E6C08C0B27F679C1F780FD83B5CFB93AB50EF::get_offset_of__elementType_0(),
	NewArrayBoundsInstruction_t5A4E6C08C0B27F679C1F780FD83B5CFB93AB50EF::get_offset_of__rank_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2011 = { sizeof (GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E), -1, sizeof(GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2011[1] = 
{
	GetArrayItemInstruction_t39F1BF484A9130A193CB6ED96E751AA0CF99506E_StaticFields::get_offset_of_Instance_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2012 = { sizeof (SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478), -1, sizeof(SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2012[1] = 
{
	SetArrayItemInstruction_tADF1CC4120E6E891C701BDC2C9445B8D7A639478_StaticFields::get_offset_of_Instance_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2013 = { sizeof (ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214), -1, sizeof(ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2013[1] = 
{
	ArrayLengthInstruction_t0B377310312E7649BBE3DF102AD6A6BF2C451214_StaticFields::get_offset_of_Instance_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2014 = { sizeof (ConvertHelper_t7A009D993A13DC4734775DFE75D15E7964E477DA), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2015 = { sizeof (RuntimeLabel_t0FAE2EECA36B182898675A50204615C6149BD9E3)+ sizeof (RuntimeObject), sizeof(RuntimeLabel_t0FAE2EECA36B182898675A50204615C6149BD9E3 ), 0, 0 };
extern const int32_t g_FieldOffsetTable2015[3] = 
{
	RuntimeLabel_t0FAE2EECA36B182898675A50204615C6149BD9E3::get_offset_of_Index_0() + static_cast<int32_t>(sizeof(RuntimeObject)),
	RuntimeLabel_t0FAE2EECA36B182898675A50204615C6149BD9E3::get_offset_of_StackDepth_1() + static_cast<int32_t>(sizeof(RuntimeObject)),
	RuntimeLabel_t0FAE2EECA36B182898675A50204615C6149BD9E3::get_offset_of_ContinuationStackDepth_2() + static_cast<int32_t>(sizeof(RuntimeObject)),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2016 = { sizeof (BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2016[5] = 
{
	BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87::get_offset_of__targetIndex_0(),
	BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87::get_offset_of__stackDepth_1(),
	BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87::get_offset_of__continuationStackDepth_2(),
	BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87::get_offset_of__forwardBranchFixups_3(),
	BranchLabel_t214D1B5CFBC97C4A142CDC886C93C7FF5EE1ED87::get_offset_of_U3CLabelIndexU3Ek__BackingField_4(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2017 = { sizeof (CallInstruction_tE463EE38C397DCD089226727826DF7B48B5C0526), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2018 = { sizeof (MethodInfoCallInstruction_tD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2018[2] = 
{
	MethodInfoCallInstruction_tD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8::get_offset_of__target_0(),
	MethodInfoCallInstruction_tD45BBCFA66A742D8CB4CC4C981FE5BBADE8C3DC8::get_offset_of__argumentCount_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2019 = { sizeof (ByRefMethodInfoCallInstruction_tCC12111BCAA3FBFBE597709AA68BEE9C07CFC33F), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2019[1] = 
{
	ByRefMethodInfoCallInstruction_tCC12111BCAA3FBFBE597709AA68BEE9C07CFC33F::get_offset_of__byrefArgs_2(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2020 = { sizeof (OffsetInstruction_tC6482B97ABF5D496066EBCFB48B452115DF00063), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2020[1] = 
{
	OffsetInstruction_tC6482B97ABF5D496066EBCFB48B452115DF00063::get_offset_of__offset_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2021 = { sizeof (BranchFalseInstruction_tBCEFD036D44D8431140FC018715991383689C266), -1, sizeof(BranchFalseInstruction_tBCEFD036D44D8431140FC018715991383689C266_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2021[1] = 
{
	BranchFalseInstruction_tBCEFD036D44D8431140FC018715991383689C266_StaticFields::get_offset_of_s_cache_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2022 = { sizeof (BranchTrueInstruction_tB3E3FA83B686AE558530592545AB3ED5C75801E7), -1, sizeof(BranchTrueInstruction_tB3E3FA83B686AE558530592545AB3ED5C75801E7_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2022[1] = 
{
	BranchTrueInstruction_tB3E3FA83B686AE558530592545AB3ED5C75801E7_StaticFields::get_offset_of_s_cache_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2023 = { sizeof (CoalescingBranchInstruction_t1A16855A8392EF113D1F9840737F4C79C0DE2D8B), -1, sizeof(CoalescingBranchInstruction_t1A16855A8392EF113D1F9840737F4C79C0DE2D8B_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2023[1] = 
{
	CoalescingBranchInstruction_t1A16855A8392EF113D1F9840737F4C79C0DE2D8B_StaticFields::get_offset_of_s_cache_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2024 = { sizeof (BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149), -1, sizeof(BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2024[3] = 
{
	BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149_StaticFields::get_offset_of_s_caches_1(),
	BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149::get_offset_of__hasResult_2(),
	BranchInstruction_t87613F18047B07A63B644BEF6537677D525A1149::get_offset_of__hasValue_3(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2025 = { sizeof (IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2025[1] = 
{
	IndexedBranchInstruction_t518A5A2689EC6F443B8556FDD556C6594827A77E::get_offset_of__labelIndex_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2026 = { sizeof (GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3), -1, sizeof(GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2026[4] = 
{
	GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3_StaticFields::get_offset_of_s_cache_1(),
	GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3::get_offset_of__hasResult_2(),
	GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3::get_offset_of__hasValue_3(),
	GotoInstruction_t6FF004167D50525C4E5FF1C2E2B339E54F2392B3::get_offset_of__labelTargetGetsValue_4(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2027 = { sizeof (EnterTryCatchFinallyInstruction_t812A2C0330D60FE93D57B23F588DBF4709776832), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2027[2] = 
{
	EnterTryCatchFinallyInstruction_t812A2C0330D60FE93D57B23F588DBF4709776832::get_offset_of__hasFinally_1(),
	EnterTryCatchFinallyInstruction_t812A2C0330D60FE93D57B23F588DBF4709776832::get_offset_of__tryHandler_2(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2028 = { sizeof (EnterTryFaultInstruction_t97D7427906E383FA3F14CDD060DA8B35E5B553DE), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2028[1] = 
{
	EnterTryFaultInstruction_t97D7427906E383FA3F14CDD060DA8B35E5B553DE::get_offset_of__tryHandler_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2029 = { sizeof (EnterFinallyInstruction_t680113D68611CB2F0360244809742BB577D027F3), -1, sizeof(EnterFinallyInstruction_t680113D68611CB2F0360244809742BB577D027F3_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2029[1] = 
{
	EnterFinallyInstruction_t680113D68611CB2F0360244809742BB577D027F3_StaticFields::get_offset_of_s_cache_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2030 = { sizeof (LeaveFinallyInstruction_tA5945AD963154A41F127F635BB13A911E632B290), -1, sizeof(LeaveFinallyInstruction_tA5945AD963154A41F127F635BB13A911E632B290_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2030[1] = 
{
	LeaveFinallyInstruction_tA5945AD963154A41F127F635BB13A911E632B290_StaticFields::get_offset_of_Instance_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2031 = { sizeof (EnterFaultInstruction_tE9885EC49B1451211A63A8404D38D8133818EDD2), -1, sizeof(EnterFaultInstruction_tE9885EC49B1451211A63A8404D38D8133818EDD2_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2031[1] = 
{
	EnterFaultInstruction_tE9885EC49B1451211A63A8404D38D8133818EDD2_StaticFields::get_offset_of_s_cache_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2032 = { sizeof (LeaveFaultInstruction_t1539C9677C606E3190D4E0B0DAB51CC44A794DD0), -1, sizeof(LeaveFaultInstruction_t1539C9677C606E3190D4E0B0DAB51CC44A794DD0_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2032[1] = 
{
	LeaveFaultInstruction_t1539C9677C606E3190D4E0B0DAB51CC44A794DD0_StaticFields::get_offset_of_Instance_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2033 = { sizeof (EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC), -1, sizeof(EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2033[1] = 
{
	EnterExceptionFilterInstruction_t862DD68E4F70EFC981EAC32E900EB7DC9604C3EC_StaticFields::get_offset_of_Instance_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2034 = { sizeof (LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26), -1, sizeof(LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2034[1] = 
{
	LeaveExceptionFilterInstruction_t14D166B81741912F5FAB6EADFF81EFC16E971C26_StaticFields::get_offset_of_Instance_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2035 = { sizeof (EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9), -1, sizeof(EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2035[3] = 
{
	EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9_StaticFields::get_offset_of_Void_0(),
	EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9_StaticFields::get_offset_of_NonVoid_1(),
	EnterExceptionHandlerInstruction_t96904E7A70E349971A58634403840A0C3ECDFBF9::get_offset_of__hasValue_2(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2036 = { sizeof (LeaveExceptionHandlerInstruction_t920AF0C4284902BF42FB8D58B77A58C15F0694B4), -1, sizeof(LeaveExceptionHandlerInstruction_t920AF0C4284902BF42FB8D58B77A58C15F0694B4_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2036[2] = 
{
	LeaveExceptionHandlerInstruction_t920AF0C4284902BF42FB8D58B77A58C15F0694B4_StaticFields::get_offset_of_s_cache_1(),
	LeaveExceptionHandlerInstruction_t920AF0C4284902BF42FB8D58B77A58C15F0694B4::get_offset_of__hasValue_2(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2037 = { sizeof (ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8), -1, sizeof(ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2037[7] = 
{
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields::get_offset_of_Throw_0(),
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields::get_offset_of_VoidThrow_1(),
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields::get_offset_of_Rethrow_2(),
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields::get_offset_of_VoidRethrow_3(),
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8_StaticFields::get_offset_of__runtimeWrappedExceptionCtor_4(),
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8::get_offset_of__hasResult_5(),
	ThrowInstruction_tEE229813AC045E116B79F3727238A0DAA6640DE8::get_offset_of__rethrow_6(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2038 = { 0, 0, 0, 0 };
extern const int32_t g_FieldOffsetTable2038[1] = 
{
	0,
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2039 = { sizeof (StringSwitchInstruction_t9395F34F26292304C90F5CF737E47858AF046C98), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2039[2] = 
{
	StringSwitchInstruction_t9395F34F26292304C90F5CF737E47858AF046C98::get_offset_of__cases_0(),
	StringSwitchInstruction_t9395F34F26292304C90F5CF737E47858AF046C98::get_offset_of__nullCase_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2040 = { sizeof (DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E), -1, sizeof(DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2040[8] = 
{
	DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields::get_offset_of_s_Int16_0(),
	DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields::get_offset_of_s_Int32_1(),
	DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields::get_offset_of_s_Int64_2(),
	DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields::get_offset_of_s_UInt16_3(),
	DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields::get_offset_of_s_UInt32_4(),
	DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields::get_offset_of_s_UInt64_5(),
	DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields::get_offset_of_s_Single_6(),
	DecrementInstruction_t7348431A8488943B1B7DFE21A919984F51CDB38E_StaticFields::get_offset_of_s_Double_7(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2041 = { sizeof (DecrementInt16_t685FC84C1301DAC5D22E9105078C1A30336010B3), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2042 = { sizeof (DecrementInt32_tC15CD8CDA8852F11FE5B2129D80E1FE2C8975771), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2043 = { sizeof (DecrementInt64_tEE2942340C37FF3F0140491C727EECC1B47D5EE8), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2044 = { sizeof (DecrementUInt16_t22E7EEE1C1F18B6C48B7A5DF7AB7977BEB711F76), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2045 = { sizeof (DecrementUInt32_t348386B760B938D94B5B2ED1EDAEFE2E5609DA8B), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2046 = { sizeof (DecrementUInt64_tF39E462999338D503EE7ED326C09F080BEB8A4C5), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2047 = { sizeof (DecrementSingle_t206C0302963E29C25D71BA9B69DAF5E5ACC3ADF3), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2048 = { sizeof (DecrementDouble_tDF8E382CD2029C93FBE6F0FF8FEDB5F40C794E18), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2049 = { sizeof (DefaultValueInstruction_t68CA6DB41069E83803AE7100FF7ADB87FE5FA7DE), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2049[1] = 
{
	DefaultValueInstruction_t68CA6DB41069E83803AE7100FF7ADB87FE5FA7DE::get_offset_of__type_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2050 = { sizeof (DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26), -1, sizeof(DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2050[8] = 
{
	DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields::get_offset_of_s_Int16_0(),
	DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields::get_offset_of_s_Int32_1(),
	DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields::get_offset_of_s_Int64_2(),
	DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields::get_offset_of_s_UInt16_3(),
	DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields::get_offset_of_s_UInt32_4(),
	DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields::get_offset_of_s_UInt64_5(),
	DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields::get_offset_of_s_Single_6(),
	DivInstruction_tE9B4D006902B8B7D876DE8D32EDD4C1070F26A26_StaticFields::get_offset_of_s_Double_7(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2051 = { sizeof (DivInt16_t33BFEB4C9D214D033F813FF7B6564C9DE6593B8B), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2052 = { sizeof (DivInt32_tCF776B1E1A65A2825D507A702081EFB9778B430B), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2053 = { sizeof (DivInt64_tF3A9BC3DC23720401346E79B49810B240E4C202B), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2054 = { sizeof (DivUInt16_t427CA6DB168963E37C3245AD17AE26C2AC0065B7), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2055 = { sizeof (DivUInt32_tABFBB77D7527C4373B7BA2BC0D81FF3541787EA1), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2056 = { sizeof (DivUInt64_t7083EB7CFFCA814C2CA18B8E4F40900D0C645279), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2057 = { sizeof (DivSingle_t55008BE702FA8BB0A6154722DC4C4A1865BA5873), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2058 = { sizeof (DivDouble_t8EF9EF21001315C3F8EBEC142DC2CDFAAAE006B5), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2059 = { sizeof (EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5), -1, sizeof(EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2059[25] = 
{
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_reference_0(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Boolean_1(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_SByte_2(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Int16_3(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Char_4(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Int32_5(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Int64_6(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Byte_7(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_UInt16_8(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_UInt32_9(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_UInt64_10(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Single_11(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Double_12(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_BooleanLiftedToNull_13(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_SByteLiftedToNull_14(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Int16LiftedToNull_15(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_CharLiftedToNull_16(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Int32LiftedToNull_17(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_Int64LiftedToNull_18(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_ByteLiftedToNull_19(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_UInt16LiftedToNull_20(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_UInt32LiftedToNull_21(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_UInt64LiftedToNull_22(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_SingleLiftedToNull_23(),
	EqualInstruction_tAA16066A49B5EDA0B9D22B19DF7130B00DF34AD5_StaticFields::get_offset_of_s_DoubleLiftedToNull_24(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2060 = { sizeof (EqualBoolean_tE4F1D48A660020E715A59756C4471130AF37E621), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2061 = { sizeof (EqualSByte_tE71DE060A984D4BABA1110B8C379981A11A84CF2), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2062 = { sizeof (EqualInt16_t2E33878A66976918FEEF7C9322919EF108C6DB92), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2063 = { sizeof (EqualChar_tAAF73D00A35D189A6F08213F31FDBAF27694432B), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2064 = { sizeof (EqualInt32_t6928A128D08F0468B738E0A9C014B52F5DFA6A03), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2065 = { sizeof (EqualInt64_t71FD9B2283FEF4234597EAA48CF7D6C285D720BB), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2066 = { sizeof (EqualByte_t49CD77E9BC018FA9826BF0DE8F827CA711739896), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2067 = { sizeof (EqualUInt16_t69E374E2D9CB2547CAE3E4C6E0DA14D6718AFC2C), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2068 = { sizeof (EqualUInt32_tA935140965CA9E077DDED610489BD03F209E7A92), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2069 = { sizeof (EqualUInt64_t5E7456016C1AB311639467C75F6D8C50C8A90B54), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2070 = { sizeof (EqualSingle_tA06CB396E70ADD7CB752237210691B6F51A05A57), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2071 = { sizeof (EqualDouble_t6EBD63109F85BAC4338108D8C65BD797571BC7C7), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2072 = { sizeof (EqualReference_t5784DC95C8F544CB7B5626C39DF458B63BAD4988), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2073 = { sizeof (EqualBooleanLiftedToNull_t9E98C34347361F37D546E20F7308D66947AF348C), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2074 = { sizeof (EqualSByteLiftedToNull_t297075E2B24E34F0DAAE6C2494F353F7EF3D3777), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2075 = { sizeof (EqualInt16LiftedToNull_t7D2B815940CCDD6E2ED463DF1FD195325CDF478A), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2076 = { sizeof (EqualCharLiftedToNull_t03FBA23BD1889A35FF49804C8B8670CD2572DAAC), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2077 = { sizeof (EqualInt32LiftedToNull_t997D977FEF539500D5492BB4D0DBC66E9050661F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2078 = { sizeof (EqualInt64LiftedToNull_t38E8E36295D97C64606C84D5C9B5D5ECAB8881BD), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2079 = { sizeof (EqualByteLiftedToNull_t47FF7CEC1BC44891A4D1E884EEC21C20D409ABCD), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2080 = { sizeof (EqualUInt16LiftedToNull_tF7AF9237412B0BC1AAF0E20C45538ECD7D9F562C), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2081 = { sizeof (EqualUInt32LiftedToNull_tDC3B6AC8ED6BBBAB01051A3A673FD2C0C5EBB8BC), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2082 = { sizeof (EqualUInt64LiftedToNull_t1F3349D0E5FA97DB739B0002F7866662D92A92C2), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2083 = { sizeof (EqualSingleLiftedToNull_tC9885AA62E349C6EAE166F0631F020F1724D1B39), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2084 = { sizeof (EqualDoubleLiftedToNull_t00F6BD6EEFA2059762CFBA753FCDDC6D032B9C55), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2085 = { sizeof (ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B), -1, sizeof(ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable2085[9] = 
{
	ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields::get_offset_of_s_SByte_0(),
	ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields::get_offset_of_s_Int16_1(),
	ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields::get_offset_of_s_Int32_2(),
	ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields::get_offset_of_s_Int64_3(),
	ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields::get_offset_of_s_Byte_4(),
	ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields::get_offset_of_s_UInt16_5(),
	ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields::get_offset_of_s_UInt32_6(),
	ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields::get_offset_of_s_UInt64_7(),
	ExclusiveOrInstruction_tE00833508F8745D38AC819C06FB26BDE59E5E91B_StaticFields::get_offset_of_s_Boolean_8(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2086 = { sizeof (ExclusiveOrSByte_t8250C02D10E6E7225200CB69B66ADA0494BF4F67), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2087 = { sizeof (ExclusiveOrInt16_t699125E97671E3781715279BBD8AC75FCA9F9188), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2088 = { sizeof (ExclusiveOrInt32_t4E5C6C5DDAF97096AD8CE0A64674FFC31DF4DCAA), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2089 = { sizeof (ExclusiveOrInt64_tD157C18892783602CBF1CF35354F77B387DCE465), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2090 = { sizeof (ExclusiveOrByte_t0D98D60BFE7DBF0AB3512ADC48255075290564C4), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2091 = { sizeof (ExclusiveOrUInt16_t16633E139C7C947E1CEA3D951E869BF36880BFDE), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2092 = { sizeof (ExclusiveOrUInt32_t949A7AD98BBE1971B53DD718B0A8677B22B6013F), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2093 = { sizeof (ExclusiveOrUInt64_t702A2B2F4F25815CB8818DD2DDE4FB499C9C4B5B), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2094 = { sizeof (ExclusiveOrBoolean_tC234E95444AC0B93F97109462C6C801DD102E77C), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2095 = { sizeof (FieldInstruction_tE97586CE791336617EC1BA6284504911B7558E5A), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2095[1] = 
{
	FieldInstruction_tE97586CE791336617EC1BA6284504911B7558E5A::get_offset_of__field_0(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2096 = { sizeof (LoadStaticFieldInstruction_t3080FBE8B7BC9AA5EBE3181C18103F38397763D2), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2097 = { sizeof (LoadFieldInstruction_t4DD226BB90CBE3BA519C3F96969E004EC65FF3F0), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2098 = { sizeof (StoreFieldInstruction_t4DEC9E11390102F8097F18519A45A58256E51188), -1, 0, 0 };
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2099 = { sizeof (StoreStaticFieldInstruction_t96E178E14E4460C9666EC4C650B3E24FD914D6AD), -1, 0, 0 };
#ifdef __clang__
#pragma clang diagnostic pop
#endif
