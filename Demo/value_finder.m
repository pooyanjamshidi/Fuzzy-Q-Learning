function qvalue=value_finder(state,action,vector)
%% compute o_p=sum{w(j)*x_p(j)}
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


qvalue=vector(action,1)+(vector(action,2)*state);