# Assignment 2 : State machine for traffic light.

## Topics:
>> #### State machines
>> #### selections preferbly switch
>> #### Class
>> #### Enum


### Given
#### An enum **State** with four states: GREEN, RED, YELLOWTORED, YELLOWTOGREEN
#### A Class [StateMachine](StateMachine.cs)

## Construct a **public** Class **StateMachine** with:
1. **public** readonly attribute state of type **State**
>> The attribute State is holding the state of the "device" and this can only be one of the four enum values.

2. **public** Constructor taking **one** parameter *State initialState* 
>> The parameter initialState sets the initial State of the "device".

3. A **public** DoTransition Method:  *void DoTransition()*
>> This method move the "device's" internal state from a particular state to another state according to the rules specified for the device.

4. The transition rules are
>> RED -> YELLOWTOGREEN -> GREEN -> YELLOWTORED -> RED

5.When a transition is made the following should happen
>> Transition to GREEN write GREEN to console
>> Transition to RED write RED to console
>> Transition to YELLOWTORED write YELLOW to console
>> Transition to YELLOWTOGREEN write RED YELLOW to console
