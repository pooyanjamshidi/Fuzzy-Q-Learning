function delta_q=error_signal_calculator(stat)
%% This function computes the error signal
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global LAMBDA

delta_q=stat.rimm+LAMBDA*value_function_calculator(stat)-approximate_q_function(stat);

end