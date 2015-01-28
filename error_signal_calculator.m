function delta_q=error_signal_calculator(Q,current_state,next_state,ais)
%% This function computes the error signal
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)

global LAMBDA

delta_q=reward_calculator(current_state,next_state)+LAMBDA*value_function_calculator(Q,next_state)-approximate_q_function(Q,current_state,ais);

end