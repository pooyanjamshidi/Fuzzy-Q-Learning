function stat=init_vector(stat)
%% initialize vector to small numbers
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global NA


for a=1:NA
    for i=1:2
        stat.vector(a,i)=rand(1);
    end
end

% set random number generator to a fixed seed

rand('seed',1);


end